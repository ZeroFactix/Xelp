namespace Xelp
{
    partial class Xelp
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Log = new MetroFramework.Controls.MetroTabControl();
            this.Status = new MetroFramework.Controls.MetroTabPage();
            this.btnprocfolder = new MetroFramework.Controls.MetroButton();
            this.txtbxstartfolder = new MetroFramework.Controls.MetroTextBox();
            this.LblStatus = new MetroFramework.Controls.MetroLabel();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.Config = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtbxIgnoreFiles = new MetroFramework.Controls.MetroTextBox();
            this.txtbxIgnoreDir = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSaveChanges = new MetroFramework.Controls.MetroButton();
            this.txtbxReadyloc = new MetroFramework.Controls.MetroTextBox();
            this.txtbxTemploc = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.rtxtbxlog = new System.Windows.Forms.RichTextBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.link7zip = new MetroFramework.Controls.MetroLink();
            this.linkHanbrake = new MetroFramework.Controls.MetroLink();
            this.Log.SuspendLayout();
            this.Status.SuspendLayout();
            this.Config.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(336, 190);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(119, 24);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Process Media Files";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Log
            // 
            this.Log.Controls.Add(this.Status);
            this.Log.Controls.Add(this.Config);
            this.Log.Controls.Add(this.metroTabPage1);
            this.Log.Location = new System.Drawing.Point(23, 63);
            this.Log.Name = "Log";
            this.Log.SelectedIndex = 0;
            this.Log.Size = new System.Drawing.Size(463, 256);
            this.Log.TabIndex = 1;
            this.Log.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Status
            // 
            this.Status.Controls.Add(this.btnprocfolder);
            this.Status.Controls.Add(this.txtbxstartfolder);
            this.Status.Controls.Add(this.LblStatus);
            this.Status.Controls.Add(this.metroProgressSpinner1);
            this.Status.Controls.Add(this.metroButton1);
            this.Status.HorizontalScrollbarBarColor = true;
            this.Status.Location = new System.Drawing.Point(4, 35);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(455, 217);
            this.Status.TabIndex = 0;
            this.Status.Text = "Status";
            this.Status.VerticalScrollbarBarColor = true;
            // 
            // btnprocfolder
            // 
            this.btnprocfolder.Location = new System.Drawing.Point(35, 74);
            this.btnprocfolder.Name = "btnprocfolder";
            this.btnprocfolder.Size = new System.Drawing.Size(119, 24);
            this.btnprocfolder.TabIndex = 5;
            this.btnprocfolder.Text = "Process Folder";
            this.btnprocfolder.Click += new System.EventHandler(this.btnprocfolder_Click);
            // 
            // txtbxstartfolder
            // 
            this.txtbxstartfolder.Location = new System.Drawing.Point(4, 45);
            this.txtbxstartfolder.Name = "txtbxstartfolder";
            this.txtbxstartfolder.Size = new System.Drawing.Size(211, 23);
            this.txtbxstartfolder.TabIndex = 4;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(44, 13);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(74, 19);
            this.LblStatus.TabIndex = 3;
            this.LblStatus.Text = "StatusLabel";
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(4, 7);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(34, 32);
            this.metroProgressSpinner1.TabIndex = 2;
            this.metroProgressSpinner1.Visible = false;
            // 
            // Config
            // 
            this.Config.Controls.Add(this.metroLabel3);
            this.Config.Controls.Add(this.metroLabel4);
            this.Config.Controls.Add(this.txtbxIgnoreFiles);
            this.Config.Controls.Add(this.txtbxIgnoreDir);
            this.Config.Controls.Add(this.metroLabel2);
            this.Config.Controls.Add(this.metroLabel1);
            this.Config.Controls.Add(this.btnSaveChanges);
            this.Config.Controls.Add(this.txtbxReadyloc);
            this.Config.Controls.Add(this.txtbxTemploc);
            this.Config.HorizontalScrollbarBarColor = true;
            this.Config.Location = new System.Drawing.Point(4, 35);
            this.Config.Name = "Config";
            this.Config.Size = new System.Drawing.Size(455, 217);
            this.Config.TabIndex = 1;
            this.Config.Text = "Options";
            this.Config.VerticalScrollbarBarColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 107);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Ignore Files:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(1, 78);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(97, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Ignore Subdirs:";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbxIgnoreFiles
            // 
            this.txtbxIgnoreFiles.Location = new System.Drawing.Point(104, 103);
            this.txtbxIgnoreFiles.Name = "txtbxIgnoreFiles";
            this.txtbxIgnoreFiles.Size = new System.Drawing.Size(348, 23);
            this.txtbxIgnoreFiles.TabIndex = 8;
            this.txtbxIgnoreFiles.Text = "File List";
            this.txtbxIgnoreFiles.TextChanged += new System.EventHandler(this.txtbxIgnoreFiles_TextChanged);
            // 
            // txtbxIgnoreDir
            // 
            this.txtbxIgnoreDir.Location = new System.Drawing.Point(104, 74);
            this.txtbxIgnoreDir.Name = "txtbxIgnoreDir";
            this.txtbxIgnoreDir.Size = new System.Drawing.Size(348, 23);
            this.txtbxIgnoreDir.TabIndex = 7;
            this.txtbxIgnoreDir.Text = "Dir List";
            this.metroToolTip1.SetToolTip(this.txtbxIgnoreDir, " List out subdirectories that you want to ignore. Comman Seperated.");
            this.txtbxIgnoreDir.TextChanged += new System.EventHandler(this.txtbxIgnoreDir_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(-2, 49);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Processed Files:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(1, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Temp Location:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(361, 191);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(91, 23);
            this.btnSaveChanges.TabIndex = 4;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.Visible = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtbxReadyloc
            // 
            this.txtbxReadyloc.Location = new System.Drawing.Point(104, 45);
            this.txtbxReadyloc.Name = "txtbxReadyloc";
            this.txtbxReadyloc.Size = new System.Drawing.Size(348, 23);
            this.txtbxReadyloc.TabIndex = 3;
            this.txtbxReadyloc.Text = "Ready Location";
            this.txtbxReadyloc.TextChanged += new System.EventHandler(this.txtbxReadyloc_TextChanged);
            // 
            // txtbxTemploc
            // 
            this.txtbxTemploc.Location = new System.Drawing.Point(104, 16);
            this.txtbxTemploc.Name = "txtbxTemploc";
            this.txtbxTemploc.Size = new System.Drawing.Size(348, 23);
            this.txtbxTemploc.TabIndex = 2;
            this.txtbxTemploc.Text = "Temp Location";
            this.txtbxTemploc.TextChanged += new System.EventHandler(this.txtbxTemploc_TextChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.rtxtbxlog);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(455, 217);
            this.metroTabPage1.TabIndex = 2;
            this.metroTabPage1.Text = "Log";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // rtxtbxlog
            // 
            this.rtxtbxlog.Location = new System.Drawing.Point(3, 3);
            this.rtxtbxlog.Name = "rtxtbxlog";
            this.rtxtbxlog.Size = new System.Drawing.Size(452, 211);
            this.rtxtbxlog.TabIndex = 2;
            this.rtxtbxlog.Text = "";
            // 
            // link7zip
            // 
            this.link7zip.BackColor = System.Drawing.Color.DarkOrange;
            this.link7zip.CustomBackground = true;
            this.link7zip.Location = new System.Drawing.Point(23, 340);
            this.link7zip.Name = "link7zip";
            this.link7zip.Size = new System.Drawing.Size(415, 23);
            this.link7zip.TabIndex = 2;
            this.link7zip.Text = "7Zip is missing from you system. Please Click here to download";
            this.link7zip.Visible = false;
            this.link7zip.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // linkHanbrake
            // 
            this.linkHanbrake.BackColor = System.Drawing.Color.DarkOrange;
            this.linkHanbrake.CustomBackground = true;
            this.linkHanbrake.Location = new System.Drawing.Point(23, 369);
            this.linkHanbrake.Name = "linkHanbrake";
            this.linkHanbrake.Size = new System.Drawing.Size(415, 23);
            this.linkHanbrake.TabIndex = 3;
            this.linkHanbrake.Text = "Handbrake is missing from you system. Please Click here to download";
            this.linkHanbrake.Visible = false;
            this.linkHanbrake.Click += new System.EventHandler(this.linkHanbrake_Click);
            // 
            // Xelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 397);
            this.Controls.Add(this.linkHanbrake);
            this.Controls.Add(this.link7zip);
            this.Controls.Add(this.Log);
            this.Name = "Xelp";
            this.Text = "Xelp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Log.ResumeLayout(false);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.Config.ResumeLayout(false);
            this.Config.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTabControl Log;
        private MetroFramework.Controls.MetroTabPage Status;
        private MetroFramework.Controls.MetroTabPage Config;
        private MetroFramework.Controls.MetroTextBox txtbxTemploc;
        private MetroFramework.Controls.MetroTextBox txtbxReadyloc;
        private MetroFramework.Controls.MetroButton btnSaveChanges;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtbxIgnoreFiles;
        private MetroFramework.Controls.MetroTextBox txtbxIgnoreDir;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.RichTextBox rtxtbxlog;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroLabel LblStatus;
        private MetroFramework.Controls.MetroButton btnprocfolder;
        private MetroFramework.Controls.MetroTextBox txtbxstartfolder;
        private MetroFramework.Controls.MetroLink link7zip;
        private MetroFramework.Controls.MetroLink linkHanbrake;
    }
}

