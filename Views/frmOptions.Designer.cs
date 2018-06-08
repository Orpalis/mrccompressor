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
            this.tabCompression = new System.Windows.Forms.TabPage();
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
            this.tabCompression.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabCompression);
            this.tabControl1.Controls.Add(this.tabOutputFormat);
            this.tabControl1.Controls.SetChildIndex(this.tabOutputFormat, 0);
            this.tabControl1.Controls.SetChildIndex(this.tabCompression, 0);
            this.tabControl1.Controls.SetChildIndex(this.tabGeneral, 0);
            // 
            // tabCompression
            // 
            this.tabCompression.Controls.Add(this.nuImageQuality);
            this.tabCompression.Controls.Add(this.lbImageQuality);
            this.tabCompression.Controls.Add(this.lbColorCompressionScheme);
            this.tabCompression.Controls.Add(this.lbDpi);
            this.tabCompression.Controls.Add(this.chkDownscaleImages);
            this.tabCompression.Controls.Add(this.cmbBitonalCompressionScheme);
            this.tabCompression.Controls.Add(this.nuDownscaleResolution);
            this.tabCompression.Controls.Add(this.lbResolution);
            this.tabCompression.Controls.Add(this.lbBitonalCompressionScheme);
            this.tabCompression.Controls.Add(this.cmbColorCompressionScheme);
            this.tabCompression.Location = new System.Drawing.Point(4, 22);
            this.tabCompression.Margin = new System.Windows.Forms.Padding(1);
            this.tabCompression.Name = "tabCompression";
            this.tabCompression.Padding = new System.Windows.Forms.Padding(1);
            this.tabCompression.Size = new System.Drawing.Size(485, 217);
            this.tabCompression.TabIndex = 3;
            this.tabCompression.Text = "Compression";
            this.tabCompression.UseVisualStyleBackColor = true;
            // 
            // nuImageQuality
            // 
            this.nuImageQuality.Location = new System.Drawing.Point(63, 13);
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
            this.lbImageQuality.Location = new System.Drawing.Point(15, 15);
            this.lbImageQuality.Name = "lbImageQuality";
            this.lbImageQuality.Size = new System.Drawing.Size(42, 13);
            this.lbImageQuality.TabIndex = 22;
            this.lbImageQuality.Text = "Quality:";
            // 
            // lbColorCompressionScheme
            // 
            this.lbColorCompressionScheme.AutoSize = true;
            this.lbColorCompressionScheme.Location = new System.Drawing.Point(17, 41);
            this.lbColorCompressionScheme.Name = "lbColorCompressionScheme";
            this.lbColorCompressionScheme.Size = new System.Drawing.Size(172, 13);
            this.lbColorCompressionScheme.TabIndex = 20;
            this.lbColorCompressionScheme.Text = "Color images compression scheme:";
            // 
            // lbDpi
            // 
            this.lbDpi.AutoSize = true;
            this.lbDpi.Location = new System.Drawing.Point(191, 161);
            this.lbDpi.Name = "lbDpi";
            this.lbDpi.Size = new System.Drawing.Size(21, 13);
            this.lbDpi.TabIndex = 19;
            this.lbDpi.Text = "dpi";
            // 
            // chkDownscaleImages
            // 
            this.chkDownscaleImages.AutoSize = true;
            this.chkDownscaleImages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkDownscaleImages.Location = new System.Drawing.Point(20, 136);
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
            this.cmbBitonalCompressionScheme.Location = new System.Drawing.Point(20, 104);
            this.cmbBitonalCompressionScheme.Name = "cmbBitonalCompressionScheme";
            this.cmbBitonalCompressionScheme.Size = new System.Drawing.Size(123, 21);
            this.cmbBitonalCompressionScheme.TabIndex = 17;
            // 
            // nuDownscaleResolution
            // 
            this.nuDownscaleResolution.Location = new System.Drawing.Point(135, 159);
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
            this.lbResolution.Location = new System.Drawing.Point(18, 161);
            this.lbResolution.Name = "lbResolution";
            this.lbResolution.Size = new System.Drawing.Size(111, 13);
            this.lbResolution.TabIndex = 15;
            this.lbResolution.Text = "Downscale resolution:";
            // 
            // lbBitonalCompressionScheme
            // 
            this.lbBitonalCompressionScheme.AutoSize = true;
            this.lbBitonalCompressionScheme.Location = new System.Drawing.Point(17, 88);
            this.lbBitonalCompressionScheme.Name = "lbBitonalCompressionScheme";
            this.lbBitonalCompressionScheme.Size = new System.Drawing.Size(224, 13);
            this.lbBitonalCompressionScheme.TabIndex = 14;
            this.lbBitonalCompressionScheme.Text = "Black and white images compression scheme:";
            // 
            // cmbColorCompressionScheme
            // 
            this.cmbColorCompressionScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorCompressionScheme.FormattingEnabled = true;
            this.cmbColorCompressionScheme.Location = new System.Drawing.Point(19, 59);
            this.cmbColorCompressionScheme.Name = "cmbColorCompressionScheme";
            this.cmbColorCompressionScheme.Size = new System.Drawing.Size(124, 21);
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
            this.tabCompression.ResumeLayout(false);
            this.tabCompression.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuImageQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDownscaleResolution)).EndInit();
            this.tabOutputFormat.ResumeLayout(false);
            this.tabOutputFormat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabCompression;
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
    }
}