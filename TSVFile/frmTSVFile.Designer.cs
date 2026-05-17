namespace TSVFile
{
    partial class frmTSVFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTSVFile));
            this.mnsWord = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ssrWord = new System.Windows.Forms.StatusStrip();
            this.tsslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lvwWord = new System.Windows.Forms.ListView();
            this.chWord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhonogram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSoundPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExplain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.mnsWord.SuspendLayout();
            this.ssrWord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsWord
            // 
            this.mnsWord.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mnsWord.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiHelp});
            this.mnsWord.Location = new System.Drawing.Point(0, 0);
            this.mnsWord.Name = "mnsWord";
            this.mnsWord.Size = new System.Drawing.Size(1067, 33);
            this.mnsWord.TabIndex = 0;
            this.mnsWord.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(89, 29);
            this.tsmiFile.Text = "檔案(&F)";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(166, 30);
            this.tsmiOpen.Text = "開啟(&O)";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(166, 30);
            this.tsmiExit.Text = "離開(&X)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(93, 29);
            this.tsmiHelp.Text = "幫助(&H)";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(164, 30);
            this.tsmiAbout.Text = "關於(&A)";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // ssrWord
            // 
            this.ssrWord.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ssrWord.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssrWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslMessage});
            this.ssrWord.Location = new System.Drawing.Point(0, 531);
            this.ssrWord.Name = "ssrWord";
            this.ssrWord.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ssrWord.Size = new System.Drawing.Size(1067, 31);
            this.ssrWord.TabIndex = 1;
            this.ssrWord.Text = "statusStrip1";
            // 
            // tsslMessage
            // 
            this.tsslMessage.Name = "tsslMessage";
            this.tsslMessage.Size = new System.Drawing.Size(95, 25);
            this.tsslMessage.Text = "Message";
            // 
            // lvwWord
            // 
            this.lvwWord.BackColor = System.Drawing.SystemColors.Window;
            this.lvwWord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chWord,
            this.chPhonogram,
            this.chSoundPath,
            this.chExplain});
            this.lvwWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwWord.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.lvwWord.FullRowSelect = true;
            this.lvwWord.HideSelection = false;
            this.lvwWord.Location = new System.Drawing.Point(0, 33);
            this.lvwWord.Margin = new System.Windows.Forms.Padding(4);
            this.lvwWord.Name = "lvwWord";
            this.lvwWord.Size = new System.Drawing.Size(1067, 498);
            this.lvwWord.TabIndex = 2;
            this.lvwWord.UseCompatibleStateImageBehavior = false;
            this.lvwWord.View = System.Windows.Forms.View.Details;
            this.lvwWord.DoubleClick += new System.EventHandler(this.lvwWord_DoubleClick);
            // 
            // chWord
            // 
            this.chWord.Text = "單字";
            // 
            // chPhonogram
            // 
            this.chPhonogram.Text = "音標";
            this.chPhonogram.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chSoundPath
            // 
            this.chSoundPath.Text = "音檔路徑";
            this.chSoundPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSoundPath.Width = 150;
            // 
            // chExplain
            // 
            this.chExplain.Text = "解釋";
            this.chExplain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSearch.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.lblSearch.Location = new System.Drawing.Point(550, 4);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(72, 25);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "搜尋：";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.txtSearch.Location = new System.Drawing.Point(628, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 34);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1057, 521);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(10, 10);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // frmTSVFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lvwWord);
            this.Controls.Add(this.ssrWord);
            this.Controls.Add(this.mnsWord);
            this.MainMenuStrip = this.mnsWord;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTSVFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSV資料檔讀取程式";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTSVFile_FormClosing);
            this.Load += new System.EventHandler(this.frmTSVFile_Load);
            this.mnsWord.ResumeLayout(false);
            this.mnsWord.PerformLayout();
            this.ssrWord.ResumeLayout(false);
            this.ssrWord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsWord;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.StatusStrip ssrWord;
        private System.Windows.Forms.ToolStripStatusLabel tsslMessage;
        private System.Windows.Forms.ListView lvwWord;
        private System.Windows.Forms.ColumnHeader chWord;
        private System.Windows.Forms.ColumnHeader chPhonogram;
        private System.Windows.Forms.ColumnHeader chSoundPath;
        private System.Windows.Forms.ColumnHeader chExplain;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        public System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

