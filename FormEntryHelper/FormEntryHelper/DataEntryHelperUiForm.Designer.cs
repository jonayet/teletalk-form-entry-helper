namespace FormEntryHelper
{
    partial class DataEntryHelperUiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.formViewPictureBox = new System.Windows.Forms.PictureBox();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.saveAndNextButton = new System.Windows.Forms.Button();
            this.mobileNoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.formViewPictureBox)).BeginInit();
            this.viewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFolderButton.Location = new System.Drawing.Point(719, 11);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(80, 31);
            this.selectFolderButton.TabIndex = 0;
            this.selectFolderButton.Text = "Load";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // formViewPictureBox
            // 
            this.formViewPictureBox.Location = new System.Drawing.Point(3, 3);
            this.formViewPictureBox.Name = "formViewPictureBox";
            this.formViewPictureBox.Size = new System.Drawing.Size(100, 50);
            this.formViewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.formViewPictureBox.TabIndex = 1;
            this.formViewPictureBox.TabStop = false;
            // 
            // viewPanel
            // 
            this.viewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.viewPanel.AutoScroll = true;
            this.viewPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewPanel.Controls.Add(this.formViewPictureBox);
            this.viewPanel.Location = new System.Drawing.Point(17, 52);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(422, 336);
            this.viewPanel.TabIndex = 2;
            // 
            // saveAndNextButton
            // 
            this.saveAndNextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveAndNextButton.Location = new System.Drawing.Point(333, 404);
            this.saveAndNextButton.Name = "saveAndNextButton";
            this.saveAndNextButton.Size = new System.Drawing.Size(106, 32);
            this.saveAndNextButton.TabIndex = 3;
            this.saveAndNextButton.Text = "Save && Go Next!";
            this.saveAndNextButton.UseVisualStyleBackColor = true;
            this.saveAndNextButton.Click += new System.EventHandler(this.saveAndNextButton_Click);
            // 
            // mobileNoTextBox
            // 
            this.mobileNoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mobileNoTextBox.Location = new System.Drawing.Point(227, 410);
            this.mobileNoTextBox.Name = "mobileNoTextBox";
            this.mobileNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.mobileNoTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mobile No:";
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(284, 40);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "Folder Not Selected";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataEntryHelperUiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.mobileNoTextBox);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.saveAndNextButton);
            this.Controls.Add(this.selectFolderButton);
            this.Name = "DataEntryHelperUiForm";
            this.Text = "DataEntryHelperUiForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.formViewPictureBox)).EndInit();
            this.viewPanel.ResumeLayout(false);
            this.viewPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.PictureBox formViewPictureBox;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.Button saveAndNextButton;
        private System.Windows.Forms.TextBox mobileNoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infoLabel;
    }
}

