using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace FormEntryHelper
{
    public partial class DataEntryHelperUiForm : Form
    {
        private static readonly string[] FileFilters = { "*.jpg", "*.bmp" };
        private Queue<string> _filesInFolder;
        private const double ZoomScale = 2;
        private const int InfoDelay = 1000;
        private const string OutputFolder = "Output";
        private const string IdSufix = "_ID";
        private readonly Timer _infoTimer;
        private string _selectedFolderPath = "";
        private string _selectedFormPath = "";
        private string _selectedIdPath = "";
        private int _fileLeft = 0;

        public DataEntryHelperUiForm()
        {
            InitializeComponent();
            _infoTimer = new Timer() { Enabled = false, Interval = InfoDelay };
            _infoTimer.Tick += new EventHandler(infoTimer_Tick);
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            var result = folderBrowser.ShowDialog();
            if(result != DialogResult.OK) { return; }

            _selectedFolderPath = folderBrowser.SelectedPath;
            var filePaths = new List<string>();
            foreach (string filter in FileFilters)
            {
                filePaths.AddRange(Directory.GetFiles(_selectedFolderPath, filter));
            }

            filePaths.Sort();
            _filesInFolder = new Queue<string>();
            foreach (var filePath in filePaths) { _filesInFolder.Enqueue(filePath); }

            // show first form
            if (_filesInFolder.Count > 0)
            {
                SelectNextFormAndId();
                ShowSelectedFormAndImage(_selectedFormPath, _selectedIdPath);
                ShowSuccessMessage("Folder Selected");
                if (!Directory.Exists(Path.Combine(_selectedFolderPath, OutputFolder)))
                {
                    Directory.CreateDirectory(Path.Combine(_selectedFolderPath, OutputFolder));
                }
            }
            else
            {
                ShowErrorMessage("Folder Not Selected");
            }
        }

        void SelectNextFormAndId()
        {
            _fileLeft = _filesInFolder.Count;
            try
            {
                _selectedFormPath = _filesInFolder.Dequeue();
            }
            catch
            {
                _selectedFormPath = "";
            }

            try
            {
                _selectedIdPath = _filesInFolder.Dequeue();
            }
            catch
            {
                _selectedIdPath = "";
            }
        }

        private void saveAndNextButton_Click(object sender, EventArgs e)
        {
            if (_filesInFolder == null) { ShowErrorMessage("Folder Not Selected"); return; }
            if (mobileNoMaskedTextBox.Text.Length < 11) { ShowErrorMessage("Incorrect Mobile Number"); return; }
            if (string.IsNullOrEmpty(_selectedFormPath) && string.IsNullOrEmpty(_selectedFormPath)) { ShowErrorMessage("No file"); return; }
            if (string.IsNullOrEmpty(_selectedFormPath)) { ShowErrorMessage("Form is missing"); } 
            else if (string.IsNullOrEmpty(_selectedIdPath)) { ShowErrorMessage("Id is missing"); }

            string newFormPath = Path.Combine(_selectedFolderPath, OutputFolder) + @"\" + mobileNoMaskedTextBox.Text + Path.GetExtension(_selectedFormPath);
            string newIdPath = Path.Combine(_selectedFolderPath, OutputFolder) + @"\" + mobileNoMaskedTextBox.Text + IdSufix + Path.GetExtension(_selectedIdPath);
            if (File.Exists(newFormPath) && File.Exists(newIdPath)) { ShowErrorMessage("Form & ID both exist"); return; }
            if (!File.Exists(newFormPath)) { File.Move(_selectedFormPath, newFormPath); } else { ShowErrorMessage("Form exist"); }
            if (!File.Exists(newIdPath)) { File.Move(_selectedIdPath, newIdPath); } else { ShowErrorMessage("Id exist"); }

            ShowSuccessMessage("Success");
            mobileNoMaskedTextBox.Text = "015";
            mobileNoMaskedTextBox.ScrollToCaret();
            mobileNoMaskedTextBox.Focus();

            SelectNextFormAndId();
            ShowSelectedFormAndImage(_selectedFormPath, _selectedIdPath);
        }

        private void ShowSelectedFormAndImage(string formImagePath, string idImagePath)
        {
            try
            {
                Text = !string.IsNullOrEmpty(formImagePath) ? Path.GetFileNameWithoutExtension(formImagePath) + " - " + _fileLeft : "";
                using (var originalImage = new Bitmap(formImagePath))
                using (var scaledImage = new Bitmap((int) (originalImage.Width*ZoomScale), (int) (originalImage.Height*ZoomScale)))
                using (var gfx = Graphics.FromImage(scaledImage))
                {
                    gfx.DrawImage(originalImage, 0, 0, scaledImage.Width, scaledImage.Height);
                    var lastImage = formViewPictureBox.Image;
                    formViewPictureBox.Image = (Bitmap) scaledImage.Clone();
                    if (lastImage != null) { lastImage.Dispose(); }
                    formViewPanel.VerticalScroll.Value = 0;
                    formViewPanel.HorizontalScroll.Value = formViewPanel.HorizontalScroll.Maximum - 50;
                    formViewPanel.Invalidate();
                }
            }
            catch { }

            try
            {
                using (var originalImage = new Bitmap(idImagePath))
                using (var scaledImage = new Bitmap(originalImage.Width, originalImage.Height))
                using (var gfx = Graphics.FromImage(scaledImage))
                {
                    gfx.DrawImage(originalImage, 0, 0, scaledImage.Width, scaledImage.Height);
                    var lastImage = idViewPictureBox.Image;
                    idViewPictureBox.Image = (Bitmap) scaledImage.Clone();
                    if (lastImage != null) { lastImage.Dispose(); }
                    idViewPanel.VerticalScroll.Value = 0;
                    idViewPanel.HorizontalScroll.Value = idViewPanel.HorizontalScroll.Maximum - 50;
                    idViewPanel.Invalidate();
                }
            }
            catch { }
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            if (_filesInFolder == null) { ShowErrorMessage("Folder Not Selected"); return; }
            var res = MessageBox.Show("Are you sure to skip?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res != DialogResult.Yes) { return; }

            try
            {
                _selectedFormPath = _selectedIdPath;
                _selectedIdPath =_filesInFolder.Dequeue();
                _fileLeft = _filesInFolder.Count;
                ShowSelectedFormAndImage(_selectedFormPath, _selectedIdPath);
                ShowSuccessMessage("Skipped");
            }
            catch{}
        }

        void ShowSuccessMessage(string msg)
        {
            infoLabel.Text = msg;
            infoLabel.ForeColor = Color.MediumSeaGreen;
            infoLabel.Visible = true;
            _infoTimer.Enabled = true;
        }

        void ShowWarningMessage(string msg)
        {
            infoLabel.Text = msg;
            infoLabel.ForeColor = Color.Orange;
            infoLabel.Visible = true;
            _infoTimer.Enabled = true;
        }

        void ShowErrorMessage(string msg)
        {
            infoLabel.Text = msg;
            infoLabel.ForeColor = Color.Red;
            infoLabel.Visible = true;
            _infoTimer.Enabled = true;
        }

        void infoTimer_Tick(object sender, EventArgs e)
        {
            infoLabel.Visible = false;
            _infoTimer.Enabled = false;
        }
    }
}
