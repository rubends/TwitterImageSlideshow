namespace Presentation
{
    partial class SettingsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnToggleFullscreen = new System.Windows.Forms.Button();
            this.btnOpenFolderBrowser = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnReloadImages = new System.Windows.Forms.Button();
            this.btnPrevSlide = new System.Windows.Forms.Button();
            this.btnNextSlide = new System.Windows.Forms.Button();
            this.numericSlideTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTwitterSearch = new System.Windows.Forms.TextBox();
            this.btnSetSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericImageGroupSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericMaxTweets = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numericSlideTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericImageGroupSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxTweets)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToggleFullscreen
            // 
            this.btnToggleFullscreen.Location = new System.Drawing.Point(303, 49);
            this.btnToggleFullscreen.Name = "btnToggleFullscreen";
            this.btnToggleFullscreen.Size = new System.Drawing.Size(144, 40);
            this.btnToggleFullscreen.TabIndex = 1;
            this.btnToggleFullscreen.Text = "Toggle fullscreen";
            this.btnToggleFullscreen.UseVisualStyleBackColor = true;
            this.btnToggleFullscreen.Click += new System.EventHandler(this.btnToggleFullscreen_Click);
            // 
            // btnOpenFolderBrowser
            // 
            this.btnOpenFolderBrowser.Location = new System.Drawing.Point(3, 3);
            this.btnOpenFolderBrowser.Name = "btnOpenFolderBrowser";
            this.btnOpenFolderBrowser.Size = new System.Drawing.Size(144, 40);
            this.btnOpenFolderBrowser.TabIndex = 2;
            this.btnOpenFolderBrowser.Text = "Choose image folder";
            this.btnOpenFolderBrowser.UseVisualStyleBackColor = true;
            this.btnOpenFolderBrowser.Click += new System.EventHandler(this.btnOpenFolderBrowser_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "v";
            // 
            // btnReloadImages
            // 
            this.btnReloadImages.Location = new System.Drawing.Point(153, 3);
            this.btnReloadImages.Name = "btnReloadImages";
            this.btnReloadImages.Size = new System.Drawing.Size(144, 40);
            this.btnReloadImages.TabIndex = 3;
            this.btnReloadImages.Text = "Reload images";
            this.btnReloadImages.UseVisualStyleBackColor = true;
            this.btnReloadImages.Click += new System.EventHandler(this.btnReloadImages_Click);
            // 
            // btnPrevSlide
            // 
            this.btnPrevSlide.Location = new System.Drawing.Point(3, 49);
            this.btnPrevSlide.Name = "btnPrevSlide";
            this.btnPrevSlide.Size = new System.Drawing.Size(65, 40);
            this.btnPrevSlide.TabIndex = 4;
            this.btnPrevSlide.Text = "<<";
            this.btnPrevSlide.UseVisualStyleBackColor = true;
            this.btnPrevSlide.Click += new System.EventHandler(this.btnPrevSlide_Click);
            // 
            // btnNextSlide
            // 
            this.btnNextSlide.Location = new System.Drawing.Point(84, 49);
            this.btnNextSlide.Name = "btnNextSlide";
            this.btnNextSlide.Size = new System.Drawing.Size(63, 40);
            this.btnNextSlide.TabIndex = 5;
            this.btnNextSlide.Text = ">>";
            this.btnNextSlide.UseVisualStyleBackColor = true;
            this.btnNextSlide.Click += new System.EventHandler(this.btnNextSlide_Click);
            // 
            // numericSlideTime
            // 
            this.numericSlideTime.Location = new System.Drawing.Point(156, 67);
            this.numericSlideTime.Name = "numericSlideTime";
            this.numericSlideTime.Size = new System.Drawing.Size(141, 20);
            this.numericSlideTime.TabIndex = 6;
            this.numericSlideTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericSlideTime.ValueChanged += new System.EventHandler(this.numericSlideTime_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seconds between slides";
            // 
            // txtTwitterSearch
            // 
            this.txtTwitterSearch.Location = new System.Drawing.Point(3, 122);
            this.txtTwitterSearch.Name = "txtTwitterSearch";
            this.txtTwitterSearch.Size = new System.Drawing.Size(294, 20);
            this.txtTwitterSearch.TabIndex = 8;
            // 
            // btnSetSearch
            // 
            this.btnSetSearch.Location = new System.Drawing.Point(303, 122);
            this.btnSetSearch.Name = "btnSetSearch";
            this.btnSetSearch.Size = new System.Drawing.Size(144, 20);
            this.btnSetSearch.TabIndex = 9;
            this.btnSetSearch.Text = "Set search query";
            this.btnSetSearch.UseVisualStyleBackColor = true;
            this.btnSetSearch.Click += new System.EventHandler(this.btnSetSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Group images per";
            // 
            // numericImageGroupSize
            // 
            this.numericImageGroupSize.Location = new System.Drawing.Point(303, 22);
            this.numericImageGroupSize.Name = "numericImageGroupSize";
            this.numericImageGroupSize.Size = new System.Drawing.Size(144, 20);
            this.numericImageGroupSize.TabIndex = 10;
            this.numericImageGroupSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericImageGroupSize.ValueChanged += new System.EventHandler(this.numericImageGroupSize_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Maximum # of tweets";
            // 
            // numericMaxTweets
            // 
            this.numericMaxTweets.Location = new System.Drawing.Point(3, 175);
            this.numericMaxTweets.Name = "numericMaxTweets";
            this.numericMaxTweets.Size = new System.Drawing.Size(144, 20);
            this.numericMaxTweets.TabIndex = 12;
            this.numericMaxTweets.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericMaxTweets.ValueChanged += new System.EventHandler(this.numericMaxTweets_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Search query";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(246, 106);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "More info";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericMaxTweets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericImageGroupSize);
            this.Controls.Add(this.btnSetSearch);
            this.Controls.Add(this.txtTwitterSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericSlideTime);
            this.Controls.Add(this.btnNextSlide);
            this.Controls.Add(this.btnPrevSlide);
            this.Controls.Add(this.btnReloadImages);
            this.Controls.Add(this.btnOpenFolderBrowser);
            this.Controls.Add(this.btnToggleFullscreen);
            this.Name = "SettingsView";
            this.Size = new System.Drawing.Size(453, 289);
            this.Load += new System.EventHandler(this.SettingsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericSlideTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericImageGroupSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxTweets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnToggleFullscreen;
        private System.Windows.Forms.Button btnOpenFolderBrowser;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnReloadImages;
        private System.Windows.Forms.Button btnPrevSlide;
        private System.Windows.Forms.Button btnNextSlide;
        private System.Windows.Forms.NumericUpDown numericSlideTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTwitterSearch;
        private System.Windows.Forms.Button btnSetSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericImageGroupSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericMaxTweets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
