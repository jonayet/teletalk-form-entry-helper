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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataEntryHelperUiForm));
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.formViewPictureBox = new System.Windows.Forms.PictureBox();
            this.formViewPanel = new System.Windows.Forms.Panel();
            this.saveAndNextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.idViewPanel = new System.Windows.Forms.Panel();
            this.idViewPictureBox = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mobileNoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.skipButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.formViewPictureBox)).BeginInit();
            this.formViewPanel.SuspendLayout();
            this.idViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idViewPictureBox)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFolderButton.Location = new System.Drawing.Point(680, 9);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(119, 31);
            this.selectFolderButton.TabIndex = 0;
            this.selectFolderButton.TabStop = false;
            this.selectFolderButton.Text = "Load";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // formViewPictureBox
            // 
            this.formViewPictureBox.Location = new System.Drawing.Point(3, 3);
            this.formViewPictureBox.Name = "formViewPictureBox";
            this.formViewPictureBox.Size = new System.Drawing.Size(391, 344);
            this.formViewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.formViewPictureBox.TabIndex = 1;
            this.formViewPictureBox.TabStop = false;
            // 
            // formViewPanel
            // 
            this.formViewPanel.AutoScroll = true;
            this.formViewPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.formViewPanel.Controls.Add(this.formViewPictureBox);
            this.formViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formViewPanel.Location = new System.Drawing.Point(0, 0);
            this.formViewPanel.Name = "formViewPanel";
            this.formViewPanel.Size = new System.Drawing.Size(397, 350);
            this.formViewPanel.TabIndex = 2;
            // 
            // saveAndNextButton
            // 
            this.saveAndNextButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveAndNextButton.Location = new System.Drawing.Point(303, 404);
            this.saveAndNextButton.Name = "saveAndNextButton";
            this.saveAndNextButton.Size = new System.Drawing.Size(106, 32);
            this.saveAndNextButton.TabIndex = 1;
            this.saveAndNextButton.Text = "Save && Go Next!";
            this.saveAndNextButton.UseVisualStyleBackColor = true;
            this.saveAndNextButton.Click += new System.EventHandler(this.saveAndNextButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mobile No:";
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(662, 31);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "Folder Not Selected";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idViewPanel
            // 
            this.idViewPanel.AutoScroll = true;
            this.idViewPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.idViewPanel.Controls.Add(this.idViewPictureBox);
            this.idViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idViewPanel.Location = new System.Drawing.Point(0, 0);
            this.idViewPanel.Name = "idViewPanel";
            this.idViewPanel.Size = new System.Drawing.Size(386, 350);
            this.idViewPanel.TabIndex = 7;
            // 
            // idViewPictureBox
            // 
            this.idViewPictureBox.Location = new System.Drawing.Point(3, 3);
            this.idViewPictureBox.Name = "idViewPictureBox";
            this.idViewPictureBox.Size = new System.Drawing.Size(380, 344);
            this.idViewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.idViewPictureBox.TabIndex = 1;
            this.idViewPictureBox.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 48);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.formViewPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.idViewPanel);
            this.splitContainer1.Size = new System.Drawing.Size(787, 350);
            this.splitContainer1.SplitterDistance = 397;
            this.splitContainer1.TabIndex = 8;
            this.splitContainer1.TabStop = false;
            // 
            // mobileNoMaskedTextBox
            // 
            this.mobileNoMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mobileNoMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNoMaskedTextBox.Location = new System.Drawing.Point(158, 406);
            this.mobileNoMaskedTextBox.Mask = "\\01500000000";
            this.mobileNoMaskedTextBox.Name = "mobileNoMaskedTextBox";
            this.mobileNoMaskedTextBox.Size = new System.Drawing.Size(130, 26);
            this.mobileNoMaskedTextBox.TabIndex = 0;
            // 
            // skipButton
            // 
            this.skipButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skipButton.Location = new System.Drawing.Point(555, 9);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(119, 31);
            this.skipButton.TabIndex = 10;
            this.skipButton.TabStop = false;
            this.skipButton.Text = "Skip";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // DataEntryHelperUiForm
            // 
            this.AcceptButton = this.saveAndNextButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 448);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.mobileNoMaskedTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.saveAndNextButton);
            this.Controls.Add(this.selectFolderButton);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataEntryHelperUiForm";
            this.Text = "Data Entry Helper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.formViewPictureBox)).EndInit();
            this.formViewPanel.ResumeLayout(false);
            this.formViewPanel.PerformLayout();
            this.idViewPanel.ResumeLayout(false);
            this.idViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idViewPictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.PictureBox formViewPictureBox;
        private System.Windows.Forms.Panel formViewPanel;
        private System.Windows.Forms.Button saveAndNextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Panel idViewPanel;
        private System.Windows.Forms.PictureBox idViewPictureBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MaskedTextBox mobileNoMaskedTextBox;
        private System.Windows.Forms.Button skipButton;
    }
}

