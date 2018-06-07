namespace MRCCompressor.Views
{
    partial class frmOptions
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
            this.tabImages = new System.Windows.Forms.TabPage();
            this.chkCompressBitonalImages = new System.Windows.Forms.CheckBox();
            this.chkCompressColorImages = new System.Windows.Forms.CheckBox();
            this.lbDownscaling = new System.Windows.Forms.Label();
            this.lbCompression = new System.Windows.Forms.Label();
            this.nuImageQuality = new System.Windows.Forms.NumericUpDown();
            this.lbImageQuality = new System.Windows.Forms.Label();
            this.lbColorCompressionScheme = new System.Windows.Forms.Label();
            this.lbDpi = new System.Windows.Forms.Label();
            this.chkDownscaleImages = new System.Windows.Forms.CheckBox();
            this.cmbBitonalCompressionScheme = new System.Windows.Forms.ComboBox();
            this.nuDownscaleResolution = new System.Windows.Forms.NumericUpDown();
            this.lbResolution = new System.Windows.Forms.Label();
            this.lbBitonalCompressionScheme = new System.Windows.Forms.Label();
            this.cmbColorCompressionScheme = new System.Windows.Forms.ComboBox();
            this.tabOutputFormat = new System.Windows.Forms.TabPage();
            this.cmbPdfVersion = new System.Windows.Forms.ComboBox();
            this.lbPdfVersion = new System.Windows.Forms.Label();
            this.chkFastWebView = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuImageQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDownscaleResolution)).BeginInit();
            this.tabOutputFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGeneral
            // 
            this.tabGeneral.Margin = new System.Windows.Forms.Padding(1);
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabImages);
            this.tabControl1.Controls.Add(this.tabOutputFormat);
            this.tabControl1.Controls.SetChildIndex(this.tabOutputFormat, 0);
            this.tabControl1.Controls.SetChildIndex(this.tabImages, 0);
            this.tabControl1.Controls.SetChildIndex(this.tabGeneral, 0);
            // 
            // tabImages
            // 
            this.tabImages.Controls.Add(this.chkCompressBitonalImages);
            this.tabImages.Controls.Add(this.chkCompressColorImages);
            this.tabImages.Controls.Add(this.lbDownscaling);
            this.tabImages.Controls.Add(this.lbCompression);
            this.tabImages.Controls.Add(this.nuImageQuality);
            this.tabImages.Controls.Add(this.lbImageQuality);
            this.tabImages.Controls.Add(this.lbColorCompressionScheme);
            this.tabImages.Controls.Add(this.lbDpi);
            this.tabImages.Controls.Add(this.chkDownscaleImages);
            this.tabImages.Controls.Add(this.cmbBitonalCompressionScheme);
            this.tabImages.Controls.Add(this.nuDownscaleResolution);
            this.tabImages.Controls.Add(this.lbResolution);
            this.tabImages.Controls.Add(this.lbBitonalCompressionScheme);
            this.tabImages.Controls.Add(this.cmbColorCompressionScheme);
            this.tabImages.Location = new System.Drawing.Point(4, 22);
            this.tabImages.Margin = new System.Windows.Forms.Padding(1);
            this.tabImages.Name = "tabImages";
            this.tabImages.Padding = new System.Windows.Forms.Padding(1);
            this.tabImages.Size = new System.Drawing.Size(485, 217);
            this.tabImages.TabIndex = 3;
            this.tabImages.Text = "Images";
            this.tabImages.UseVisualStyleBackColor = true;
            // 
            // chkCompressBitonalImages
            // 
            this.chkCompressBitonalImages.AutoSize = true;
            this.chkCompressBitonalImages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkCompressBitonalImages.Location = new System.Drawing.Point(240, 62);
            this.chkCompressBitonalImages.Name = "chkCompressBitonalImages";
            this.chkCompressBitonalImages.Size = new System.Drawing.Size(186, 17);
            this.chkCompressBitonalImages.TabIndex = 27;
            this.chkCompressBitonalImages.Text = "Compress black and white images";
            this.chkCompressBitonalImages.UseVisualStyleBackColor = true;
            // 
            // chkCompressColorImages
            // 
            this.chkCompressColorImages.AutoSize = true;
            this.chkCompressColorImages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkCompressColorImages.Location = new System.Drawing.Point(31, 62);
            this.chkCompressColorImages.Name = "chkCompressColorImages";
            this.chkCompressColorImages.Size = new System.Drawing.Size(134, 17);
            this.chkCompressColorImages.TabIndex = 26;
            this.chkCompressColorImages.Text = "Compress color images";
            this.chkCompressColorImages.UseVisualStyleBackColor = true;
            // 
            // lbDownscaling
            // 
            this.lbDownscaling.AutoSize = true;
            this.lbDownscaling.Location = new System.Drawing.Point(15, 142);
            this.lbDownscaling.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbDownscaling.Name = "lbDownscaling";
            this.lbDownscaling.Size = new System.Drawing.Size(71, 13);
            this.lbDownscaling.TabIndex = 25;
            this.lbDownscaling.Text = "Downscaling:";
            // 
            // lbCompression
            // 
            this.lbCompression.AutoSize = true;
            this.lbCompression.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbCompression.Location = new System.Drawing.Point(15, 15);
            this.lbCompression.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbCompression.Name = "lbCompression";
            this.lbCompression.Size = new System.Drawing.Size(70, 13);
            this.lbCompression.TabIndex = 24;
            this.lbCompression.Text = "Compression:";
            // 
            // nuImageQuality
            // 
            this.nuImageQuality.Location = new System.Drawing.Point(74, 36);
            this.nuImageQuality.Name = "nuImageQuality";
            this.nuImageQuality.Size = new System.Drawing.Size(50, 20);
            this.nuImageQuality.TabIndex = 23;
            this.nuImageQuality.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lbImageQuality
            // 
            this.lbImageQuality.AutoSize = true;
            this.lbImageQuality.Location = new System.Drawing.Point(28, 38);
            this.lbImageQuality.Name = "lbImageQuality";
            this.lbImageQuality.Size = new System.Drawing.Size(42, 13);
            this.lbImageQuality.TabIndex = 22;
            this.lbImageQuality.Text = "Quality:";
            // 
            // lbColorCompressionScheme
            // 
            this.lbColorCompressionScheme.AutoSize = true;
            this.lbColorCompressionScheme.Location = new System.Drawing.Point(28, 86);
            this.lbColorCompressionScheme.Name = "lbColorCompressionScheme";
            this.lbColorCompressionScheme.Size = new System.Drawing.Size(110, 13);
            this.lbColorCompressionScheme.TabIndex = 20;
            this.lbColorCompressionScheme.Text = "Compression scheme:";
            // 
            // lbDpi
            // 
            this.lbDpi.AutoSize = true;
            this.lbDpi.Location = new System.Drawing.Point(201, 191);
            this.lbDpi.Name = "lbDpi";
            this.lbDpi.Size = new System.Drawing.Size(21, 13);
            this.lbDpi.TabIndex = 19;
            this.lbDpi.Text = "dpi";
            // 
            // chkDownscaleImages
            // 
            this.chkDownscaleImages.AutoSize = true;
            this.chkDownscaleImages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkDownscaleImages.Location = new System.Drawing.Point(30, 167);
            this.chkDownscaleImages.Name = "chkDownscaleImages";
            this.chkDownscaleImages.Size = new System.Drawing.Size(115, 17);
            this.chkDownscaleImages.TabIndex = 18;
            this.chkDownscaleImages.Text = "Downscale images";
            this.chkDownscaleImages.UseVisualStyleBackColor = true;
            // 
            // cmbBitonalCompressionScheme
            // 
            this.cmbBitonalCompressionScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBitonalCompressionScheme.FormattingEnabled = true;
            this.cmbBitonalCompressionScheme.Location = new System.Drawing.Point(240, 108);
            this.cmbBitonalCompressionScheme.Name = "cmbBitonalCompressionScheme";
            this.cmbBitonalCompressionScheme.Size = new System.Drawing.Size(94, 21);
            this.cmbBitonalCompressionScheme.TabIndex = 17;
            // 
            // nuDownscaleResolution
            // 
            this.nuDownscaleResolution.Location = new System.Drawing.Point(145, 189);
            this.nuDownscaleResolution.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.nuDownscaleResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuDownscaleResolution.Name = "nuDownscaleResolution";
            this.nuDownscaleResolution.Size = new System.Drawing.Size(50, 20);
            this.nuDownscaleResolution.TabIndex = 16;
            this.nuDownscaleResolution.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // lbResolution
            // 
            this.lbResolution.AutoSize = true;
            this.lbResolution.Location = new System.Drawing.Point(28, 191);
            this.lbResolution.Name = "lbResolution";
            this.lbResolution.Size = new System.Drawing.Size(111, 13);
            this.lbResolution.TabIndex = 15;
            this.lbResolution.Text = "Downscale resolution:";
            // 
            // lbBitonalCompressionScheme
            // 
            this.lbBitonalCompressionScheme.AutoSize = true;
            this.lbBitonalCompressionScheme.Location = new System.Drawing.Point(237, 86);
            this.lbBitonalCompressionScheme.Name = "lbBitonalCompressionScheme";
            this.lbBitonalCompressionScheme.Size = new System.Drawing.Size(110, 13);
            this.lbBitonalCompressionScheme.TabIndex = 14;
            this.lbBitonalCompressionScheme.Text = "Compression scheme:";
            // 
            // cmbColorCompressionScheme
            // 
            this.cmbColorCompressionScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorCompressionScheme.FormattingEnabled = true;
            this.cmbColorCompressionScheme.Location = new System.Drawing.Point(30, 108);
            this.cmbColorCompressionScheme.Name = "cmbColorCompressionScheme";
            this.cmbColorCompressionScheme.Size = new System.Drawing.Size(94, 21);
            this.cmbColorCompressionScheme.TabIndex = 8;
            // 
            // tabOutputFormat
            // 
            this.tabOutputFormat.Controls.Add(this.cmbPdfVersion);
            this.tabOutputFormat.Controls.Add(this.lbPdfVersion);
            this.tabOutputFormat.Controls.Add(this.chkFastWebView);
            this.tabOutputFormat.Location = new System.Drawing.Point(4, 22);
            this.tabOutputFormat.Margin = new System.Windows.Forms.Padding(1);
            this.tabOutputFormat.Name = "tabOutputFormat";
            this.tabOutputFormat.Padding = new System.Windows.Forms.Padding(1);
            this.tabOutputFormat.Size = new System.Drawing.Size(485, 217);
            this.tabOutputFormat.TabIndex = 4;
            this.tabOutputFormat.Text = "Output Format";
            this.tabOutputFormat.UseVisualStyleBackColor = true;
            // 
            // cmbPdfVersion
            // 
            this.cmbPdfVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPdfVersion.FormattingEnabled = true;
            this.cmbPdfVersion.Location = new System.Drawing.Point(89, 13);
            this.cmbPdfVersion.Name = "cmbPdfVersion";
            this.cmbPdfVersion.Size = new System.Drawing.Size(130, 21);
            this.cmbPdfVersion.TabIndex = 27;
            // 
            // lbPdfVersion
            // 
            this.lbPdfVersion.AutoSize = true;
            this.lbPdfVersion.Location = new System.Drawing.Point(15, 15);
            this.lbPdfVersion.Name = "lbPdfVersion";
            this.lbPdfVersion.Size = new System.Drawing.Size(68, 13);
            this.lbPdfVersion.TabIndex = 28;
            this.lbPdfVersion.Text = "PDF version:";
            // 
            // chkFastWebView
            // 
            this.chkFastWebView.AutoSize = true;
            this.chkFastWebView.Location = new System.Drawing.Point(17, 44);
            this.chkFastWebView.Name = "chkFastWebView";
            this.chkFastWebView.Size = new System.Drawing.Size(127, 17);
            this.chkFastWebView.TabIndex = 26;
            this.chkFastWebView.Text = "Enable fast web view";
            this.chkFastWebView.UseVisualStyleBackColor = true;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 344);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmOptions";
            this.Text = "PassportPDF MRC Compressor - Options";
            this.tabControl1.ResumeLayout(false);
            this.tabImages.ResumeLayout(false);
            this.tabImages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuImageQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDownscaleResolution)).EndInit();
            this.tabOutputFormat.ResumeLayout(false);
            this.tabOutputFormat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabImages;
        private System.Windows.Forms.Label lbColorCompressionScheme;
        private System.Windows.Forms.Label lbDpi;
        private System.Windows.Forms.CheckBox chkDownscaleImages;
        private System.Windows.Forms.ComboBox cmbBitonalCompressionScheme;
        private System.Windows.Forms.NumericUpDown nuDownscaleResolution;
        private System.Windows.Forms.Label lbResolution;
        private System.Windows.Forms.Label lbBitonalCompressionScheme;
        private System.Windows.Forms.ComboBox cmbColorCompressionScheme;
        private System.Windows.Forms.Label lbImageQuality;
        private System.Windows.Forms.NumericUpDown nuImageQuality;
        private System.Windows.Forms.TabPage tabOutputFormat;
        private System.Windows.Forms.ComboBox cmbPdfVersion;
        private System.Windows.Forms.Label lbPdfVersion;
        private System.Windows.Forms.CheckBox chkFastWebView;
        private System.Windows.Forms.CheckBox chkCompressBitonalImages;
        private System.Windows.Forms.CheckBox chkCompressColorImages;
        private System.Windows.Forms.Label lbDownscaling;
        private System.Windows.Forms.Label lbCompression;
    }
}