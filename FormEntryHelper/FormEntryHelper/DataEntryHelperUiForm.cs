using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FormEntryHelper
{
    public partial class DataEntryHelperUiForm : Form
    {
        private static readonly string[] FileFilters = { "*.jpg", "*.bmp" };
        private int _fileIndex;
        private Stack<string> _files;
        private const double ZoomScale = 2;
        private const int InfoDelay = 1000;
        private const string OutputFolder = "Output";
        private readonly Timer _infoTimer;
        private string _selectedFolderPath = "";

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
            foreach (var filePath in filePaths) { _files.Push(filePath); }

            // show first form
            if (_files.Count > 0)
            {
                ViewFormImage(_files.Peek());
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

        private void saveAndNextButton_Click(object sender, EventArgs e)
        {
            if (_files == null)
            {
                ShowErrorMessage("Folder Not Selected");
                return;
            }

            if (_files.Count == 0)
            {
                ShowErrorMessage("No file");
                return;
            }

            if (string.IsNullOrEmpty(mobileNoTextBox.Text))
            {
                ShowErrorMessage("Write Mobile Number");
                return;
            }

            string selectedFile = _files.Pop();

            //mobileNoTextBox.Text + Path.GetExtension(_files[_fileIndex])
            File.Move(selectedFile, Path.Combine(_selectedFolderPath, OutputFolder) + @"\" + Path.GetFileName(selectedFile));
            if (_files.Count > (_fileIndex + 2))
            {
                ViewFormImage(selectedFile);
                mobileNoTextBox.Text = "";
            }
        }

        void ViewFormImage(string imagePath)
        {
            Text = Path.GetFileNameWithoutExtension(imagePath);
            using (var originalImage = new Bitmap(imagePath))
            using (var scaledImage = new Bitmap((int) (originalImage.Width * ZoomScale), (int) (originalImage.Height * ZoomScale)))
            using (var gfx = Graphics.FromImage(scaledImage))
            {
                gfx.DrawImage(originalImage, 0, 0, scaledImage.Width, scaledImage.Height);
                formViewPictureBox.Image = (Bitmap)scaledImage.Clone();
                viewPanel.VerticalScroll.Value = 0;
                viewPanel.HorizontalScroll.Value = viewPanel.HorizontalScroll.Maximum - 50;
                viewPanel.Invalidate();
            }
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
