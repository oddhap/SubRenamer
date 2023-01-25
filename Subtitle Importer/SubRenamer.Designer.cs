namespace Subtitle_Importer
{
    partial class frm_SubtitleImporter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tbLanguage = new System.Windows.Forms.TextBox();
            this.lblLang = new System.Windows.Forms.Label();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.tbPrefix = new System.Windows.Forms.TextBox();
            this.lblExt = new System.Windows.Forms.Label();
            this.tbExt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelFolder
            // 
            this.btnSelFolder.Location = new System.Drawing.Point(12, 93);
            this.btnSelFolder.Name = "btnSelFolder";
            this.btnSelFolder.Size = new System.Drawing.Size(142, 37);
            this.btnSelFolder.TabIndex = 0;
            this.btnSelFolder.Text = "Start";
            this.btnSelFolder.UseVisualStyleBackColor = true;
            this.btnSelFolder.Click += new System.EventHandler(this.btnSelFolder_Click);
            // 
            // tbLanguage
            // 
            this.tbLanguage.Location = new System.Drawing.Point(77, 6);
            this.tbLanguage.Name = "tbLanguage";
            this.tbLanguage.Size = new System.Drawing.Size(77, 23);
            this.tbLanguage.TabIndex = 2;
            this.tbLanguage.Text = "English";
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Location = new System.Drawing.Point(12, 9);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(59, 15);
            this.lblLang.TabIndex = 3;
            this.lblLang.Text = "Language";
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(12, 38);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(37, 15);
            this.lblPrefix.TabIndex = 5;
            this.lblPrefix.Text = "Prefix";
            // 
            // tbPrefix
            // 
            this.tbPrefix.Location = new System.Drawing.Point(77, 35);
            this.tbPrefix.Name = "tbPrefix";
            this.tbPrefix.Size = new System.Drawing.Size(77, 23);
            this.tbPrefix.TabIndex = 4;
            this.tbPrefix.Text = "eng";
            // 
            // lblExt
            // 
            this.lblExt.AutoSize = true;
            this.lblExt.Location = new System.Drawing.Point(12, 67);
            this.lblExt.Name = "lblExt";
            this.lblExt.Size = new System.Drawing.Size(58, 15);
            this.lblExt.TabIndex = 7;
            this.lblExt.Text = "Extension";
            // 
            // tbExt
            // 
            this.tbExt.Location = new System.Drawing.Point(77, 64);
            this.tbExt.Name = "tbExt";
            this.tbExt.Size = new System.Drawing.Size(77, 23);
            this.tbExt.TabIndex = 6;
            this.tbExt.Text = "srt";
            // 
            // frm_SubtitleImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 138);
            this.Controls.Add(this.lblExt);
            this.Controls.Add(this.tbExt);
            this.Controls.Add(this.lblPrefix);
            this.Controls.Add(this.tbPrefix);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.tbLanguage);
            this.Controls.Add(this.btnSelFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_SubtitleImporter";
            this.Text = "Subtitle Importer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSelFolder;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox tbLanguage;
        private Label lblLang;
        private Label lblPrefix;
        private TextBox tbPrefix;
        private Label lblExt;
        private TextBox tbExt;
    }
}