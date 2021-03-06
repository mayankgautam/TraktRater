﻿namespace TraktRater
{
    partial class TraktRater
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraktRater));
            this.grbTrakt = new System.Windows.Forms.GroupBox();
            this.txtTraktPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTraktUsername = new System.Windows.Forms.TextBox();
            this.grbTVDb = new System.Windows.Forms.GroupBox();
            this.txtTVDbAccountId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnImportRatings = new System.Windows.Forms.Button();
            this.pbrImportProgress = new System.Windows.Forms.ProgressBar();
            this.grbReport = new System.Windows.Forms.GroupBox();
            this.lblStatusMessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.txtImdbFilename = new System.Windows.Forms.TextBox();
            this.txtImdbUsername = new System.Windows.Forms.TextBox();
            this.grbImdb = new System.Windows.Forms.GroupBox();
            this.lblIMDbDescription = new System.Windows.Forms.Label();
            this.rdnImdbUsername = new System.Windows.Forms.RadioButton();
            this.rdnImdbCSV = new System.Windows.Forms.RadioButton();
            this.chkImdbWatchlist = new System.Windows.Forms.CheckBox();
            this.btnImdbBrowse = new System.Windows.Forms.Button();
            this.dlgFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.grbTMDb = new System.Windows.Forms.GroupBox();
            this.lnkTMDbStart = new System.Windows.Forms.LinkLabel();
            this.lblTMDbMessage = new System.Windows.Forms.Label();
            this.grbOptions = new System.Windows.Forms.GroupBox();
            this.chkMarkAsWatched = new System.Windows.Forms.CheckBox();
            this.grbTrakt.SuspendLayout();
            this.grbTVDb.SuspendLayout();
            this.grbReport.SuspendLayout();
            this.grbImdb.SuspendLayout();
            this.grbTMDb.SuspendLayout();
            this.grbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTrakt
            // 
            this.grbTrakt.Controls.Add(this.txtTraktPassword);
            this.grbTrakt.Controls.Add(this.label2);
            this.grbTrakt.Controls.Add(this.label1);
            this.grbTrakt.Controls.Add(this.txtTraktUsername);
            this.grbTrakt.Location = new System.Drawing.Point(12, 12);
            this.grbTrakt.Name = "grbTrakt";
            this.grbTrakt.Size = new System.Drawing.Size(443, 81);
            this.grbTrakt.TabIndex = 0;
            this.grbTrakt.TabStop = false;
            this.grbTrakt.Text = "Trakt";
            // 
            // txtTraktPassword
            // 
            this.txtTraktPassword.Location = new System.Drawing.Point(177, 46);
            this.txtTraktPassword.Name = "txtTraktPassword";
            this.txtTraktPassword.Size = new System.Drawing.Size(244, 20);
            this.txtTraktPassword.TabIndex = 3;
            this.txtTraktPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // txtTraktUsername
            // 
            this.txtTraktUsername.Location = new System.Drawing.Point(177, 20);
            this.txtTraktUsername.Name = "txtTraktUsername";
            this.txtTraktUsername.Size = new System.Drawing.Size(244, 20);
            this.txtTraktUsername.TabIndex = 1;
            this.txtTraktUsername.TextChanged += new System.EventHandler(this.txtTraktUsername_TextChanged);
            // 
            // grbTVDb
            // 
            this.grbTVDb.Controls.Add(this.txtTVDbAccountId);
            this.grbTVDb.Controls.Add(this.label3);
            this.grbTVDb.Location = new System.Drawing.Point(12, 115);
            this.grbTVDb.Name = "grbTVDb";
            this.grbTVDb.Size = new System.Drawing.Size(443, 54);
            this.grbTVDb.TabIndex = 2;
            this.grbTVDb.TabStop = false;
            this.grbTVDb.Text = "TVDb";
            // 
            // txtTVDbAccountId
            // 
            this.txtTVDbAccountId.Location = new System.Drawing.Point(177, 19);
            this.txtTVDbAccountId.Name = "txtTVDbAccountId";
            this.txtTVDbAccountId.Size = new System.Drawing.Size(244, 20);
            this.txtTVDbAccountId.TabIndex = 1;
            this.tipHelp.SetToolTip(this.txtTVDbAccountId, "The Account Identifier can be found in the account tab of\r\nhttp://thetvdb.com web" +
        "site. It is 16 hexidecimal characters e.g.\r\n\r\nEB6D329D10E3835A");
            this.txtTVDbAccountId.TextChanged += new System.EventHandler(this.txtTVDbAccountId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Account Identifier:";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(9, 99);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(352, 13);
            this.lblDetails.TabIndex = 1;
            this.lblDetails.Text = "Enter in account details for sources you wish to transfer ratings to trakt.tv:";
            // 
            // btnImportRatings
            // 
            this.btnImportRatings.Location = new System.Drawing.Point(12, 452);
            this.btnImportRatings.Name = "btnImportRatings";
            this.btnImportRatings.Size = new System.Drawing.Size(443, 26);
            this.btnImportRatings.TabIndex = 6;
            this.btnImportRatings.Text = "Start Ratings Import";
            this.btnImportRatings.UseVisualStyleBackColor = true;
            this.btnImportRatings.Click += new System.EventHandler(this.btnImportRatings_Click);
            // 
            // pbrImportProgress
            // 
            this.pbrImportProgress.Location = new System.Drawing.Point(13, 484);
            this.pbrImportProgress.Name = "pbrImportProgress";
            this.pbrImportProgress.Size = new System.Drawing.Size(442, 23);
            this.pbrImportProgress.TabIndex = 7;
            // 
            // grbReport
            // 
            this.grbReport.Controls.Add(this.lblStatusMessage);
            this.grbReport.Controls.Add(this.label5);
            this.grbReport.Location = new System.Drawing.Point(12, 522);
            this.grbReport.Name = "grbReport";
            this.grbReport.Size = new System.Drawing.Size(442, 49);
            this.grbReport.TabIndex = 8;
            this.grbReport.TabStop = false;
            this.grbReport.Text = "Report";
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.Location = new System.Drawing.Point(77, 20);
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(346, 23);
            this.lblStatusMessage.TabIndex = 1;
            this.lblStatusMessage.Text = "Ready for anything!";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Status:";
            // 
            // tipHelp
            // 
            this.tipHelp.AutoPopDelay = 10000;
            this.tipHelp.InitialDelay = 500;
            this.tipHelp.IsBalloon = true;
            this.tipHelp.ReshowDelay = 100;
            this.tipHelp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tipHelp.ToolTipTitle = "Help";
            // 
            // txtImdbFilename
            // 
            this.txtImdbFilename.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtImdbFilename.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtImdbFilename.Enabled = false;
            this.txtImdbFilename.Location = new System.Drawing.Point(177, 47);
            this.txtImdbFilename.Name = "txtImdbFilename";
            this.txtImdbFilename.Size = new System.Drawing.Size(208, 20);
            this.txtImdbFilename.TabIndex = 3;
            this.tipHelp.SetToolTip(this.txtImdbFilename, "You can export your ratings history to csv from your IMDb account settings.\r\nOnce" +
        " you have downloaded file, you can specify filename in this textbox.");
            this.txtImdbFilename.TextChanged += new System.EventHandler(this.txtImdbFilename_TextChanged);
            // 
            // txtImdbUsername
            // 
            this.txtImdbUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtImdbUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtImdbUsername.Location = new System.Drawing.Point(177, 73);
            this.txtImdbUsername.Name = "txtImdbUsername";
            this.txtImdbUsername.Size = new System.Drawing.Size(244, 20);
            this.txtImdbUsername.TabIndex = 6;
            this.tipHelp.SetToolTip(this.txtImdbUsername, resources.GetString("txtImdbUsername.ToolTip"));
            this.txtImdbUsername.TextChanged += new System.EventHandler(this.txtImdbUsername_TextChanged);
            // 
            // grbImdb
            // 
            this.grbImdb.Controls.Add(this.lblIMDbDescription);
            this.grbImdb.Controls.Add(this.rdnImdbUsername);
            this.grbImdb.Controls.Add(this.rdnImdbCSV);
            this.grbImdb.Controls.Add(this.chkImdbWatchlist);
            this.grbImdb.Controls.Add(this.txtImdbUsername);
            this.grbImdb.Controls.Add(this.btnImdbBrowse);
            this.grbImdb.Controls.Add(this.txtImdbFilename);
            this.grbImdb.Location = new System.Drawing.Point(12, 175);
            this.grbImdb.Name = "grbImdb";
            this.grbImdb.Size = new System.Drawing.Size(443, 127);
            this.grbImdb.TabIndex = 3;
            this.grbImdb.TabStop = false;
            this.grbImdb.Text = "IMDb";
            // 
            // lblIMDbDescription
            // 
            this.lblIMDbDescription.AutoSize = true;
            this.lblIMDbDescription.Location = new System.Drawing.Point(20, 20);
            this.lblIMDbDescription.Name = "lblIMDbDescription";
            this.lblIMDbDescription.Size = new System.Drawing.Size(349, 13);
            this.lblIMDbDescription.TabIndex = 1;
            this.lblIMDbDescription.Text = "Select \'CSV Ratings File\' for static file import or \'User ID\' for web retrieval:";
            // 
            // rdnImdbUsername
            // 
            this.rdnImdbUsername.AutoSize = true;
            this.rdnImdbUsername.Checked = true;
            this.rdnImdbUsername.Location = new System.Drawing.Point(21, 74);
            this.rdnImdbUsername.Name = "rdnImdbUsername";
            this.rdnImdbUsername.Size = new System.Drawing.Size(64, 17);
            this.rdnImdbUsername.TabIndex = 5;
            this.rdnImdbUsername.TabStop = true;
            this.rdnImdbUsername.Text = "User ID:";
            this.rdnImdbUsername.UseVisualStyleBackColor = true;
            // 
            // rdnImdbCSV
            // 
            this.rdnImdbCSV.AutoSize = true;
            this.rdnImdbCSV.Location = new System.Drawing.Point(21, 48);
            this.rdnImdbCSV.Name = "rdnImdbCSV";
            this.rdnImdbCSV.Size = new System.Drawing.Size(107, 17);
            this.rdnImdbCSV.TabIndex = 2;
            this.rdnImdbCSV.Text = "CSV Ratings File:";
            this.rdnImdbCSV.UseVisualStyleBackColor = true;
            this.rdnImdbCSV.CheckedChanged += new System.EventHandler(this.rdnImdbCSV_CheckedChanged);
            // 
            // chkImdbWatchlist
            // 
            this.chkImdbWatchlist.AutoSize = true;
            this.chkImdbWatchlist.Location = new System.Drawing.Point(177, 99);
            this.chkImdbWatchlist.Name = "chkImdbWatchlist";
            this.chkImdbWatchlist.Size = new System.Drawing.Size(97, 17);
            this.chkImdbWatchlist.TabIndex = 0;
            this.chkImdbWatchlist.Text = "Sync Watchlist";
            this.chkImdbWatchlist.UseVisualStyleBackColor = true;
            this.chkImdbWatchlist.CheckedChanged += new System.EventHandler(this.chkImdbWatchlist_CheckedChanged);
            // 
            // btnImdbBrowse
            // 
            this.btnImdbBrowse.Enabled = false;
            this.btnImdbBrowse.Location = new System.Drawing.Point(391, 45);
            this.btnImdbBrowse.Name = "btnImdbBrowse";
            this.btnImdbBrowse.Size = new System.Drawing.Size(29, 23);
            this.btnImdbBrowse.TabIndex = 4;
            this.btnImdbBrowse.Text = "...";
            this.btnImdbBrowse.UseVisualStyleBackColor = true;
            this.btnImdbBrowse.Click += new System.EventHandler(this.btnImdbBrowse_Click);
            // 
            // dlgFileOpen
            // 
            this.dlgFileOpen.DefaultExt = "csv";
            this.dlgFileOpen.FileName = "ratings.csv";
            this.dlgFileOpen.Filter = "CSV files|*.csv";
            // 
            // grbTMDb
            // 
            this.grbTMDb.Controls.Add(this.lnkTMDbStart);
            this.grbTMDb.Controls.Add(this.lblTMDbMessage);
            this.grbTMDb.Location = new System.Drawing.Point(13, 308);
            this.grbTMDb.Name = "grbTMDb";
            this.grbTMDb.Size = new System.Drawing.Size(443, 81);
            this.grbTMDb.TabIndex = 4;
            this.grbTMDb.TabStop = false;
            this.grbTMDb.Text = "TMDb";
            // 
            // lnkTMDbStart
            // 
            this.lnkTMDbStart.AutoSize = true;
            this.lnkTMDbStart.Location = new System.Drawing.Point(18, 52);
            this.lnkTMDbStart.Name = "lnkTMDbStart";
            this.lnkTMDbStart.Size = new System.Drawing.Size(113, 13);
            this.lnkTMDbStart.TabIndex = 1;
            this.lnkTMDbStart.TabStop = true;
            this.lnkTMDbStart.Text = "Start Request Process";
            this.lnkTMDbStart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTMDbStart_LinkClicked);
            // 
            // lblTMDbMessage
            // 
            this.lblTMDbMessage.Location = new System.Drawing.Point(17, 18);
            this.lblTMDbMessage.Name = "lblTMDbMessage";
            this.lblTMDbMessage.Size = new System.Drawing.Size(406, 44);
            this.lblTMDbMessage.TabIndex = 0;
            this.lblTMDbMessage.Text = "To get user ratings from TMDb you must first allow this application to access you" +
    "r account details. This needs to be done by you in a webbrowser.";
            // 
            // grbOptions
            // 
            this.grbOptions.Controls.Add(this.chkMarkAsWatched);
            this.grbOptions.Location = new System.Drawing.Point(13, 395);
            this.grbOptions.Name = "grbOptions";
            this.grbOptions.Size = new System.Drawing.Size(443, 51);
            this.grbOptions.TabIndex = 5;
            this.grbOptions.TabStop = false;
            this.grbOptions.Text = "Options";
            // 
            // chkMarkAsWatched
            // 
            this.chkMarkAsWatched.AutoSize = true;
            this.chkMarkAsWatched.Location = new System.Drawing.Point(21, 19);
            this.chkMarkAsWatched.Name = "chkMarkAsWatched";
            this.chkMarkAsWatched.Size = new System.Drawing.Size(276, 17);
            this.chkMarkAsWatched.TabIndex = 0;
            this.chkMarkAsWatched.Text = "Mark episodes and movies as watched if rated online";
            this.chkMarkAsWatched.UseVisualStyleBackColor = true;
            this.chkMarkAsWatched.Click += new System.EventHandler(this.chkMarkAsWatched_Click);
            // 
            // TraktRater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 582);
            this.Controls.Add(this.grbOptions);
            this.Controls.Add(this.grbTMDb);
            this.Controls.Add(this.grbImdb);
            this.Controls.Add(this.grbReport);
            this.Controls.Add(this.pbrImportProgress);
            this.Controls.Add(this.btnImportRatings);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.grbTVDb);
            this.Controls.Add(this.grbTrakt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TraktRater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trakt Rater";
            this.grbTrakt.ResumeLayout(false);
            this.grbTrakt.PerformLayout();
            this.grbTVDb.ResumeLayout(false);
            this.grbTVDb.PerformLayout();
            this.grbReport.ResumeLayout(false);
            this.grbImdb.ResumeLayout(false);
            this.grbImdb.PerformLayout();
            this.grbTMDb.ResumeLayout(false);
            this.grbTMDb.PerformLayout();
            this.grbOptions.ResumeLayout(false);
            this.grbOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTrakt;
        private System.Windows.Forms.TextBox txtTraktPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTraktUsername;
        private System.Windows.Forms.GroupBox grbTVDb;
        private System.Windows.Forms.TextBox txtTVDbAccountId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnImportRatings;
        private System.Windows.Forms.ProgressBar pbrImportProgress;
        private System.Windows.Forms.GroupBox grbReport;
        public System.Windows.Forms.Label lblStatusMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip tipHelp;
        private System.Windows.Forms.GroupBox grbImdb;
        private System.Windows.Forms.Button btnImdbBrowse;
        private System.Windows.Forms.TextBox txtImdbFilename;
        private System.Windows.Forms.OpenFileDialog dlgFileOpen;
        private System.Windows.Forms.GroupBox grbTMDb;
        private System.Windows.Forms.LinkLabel lnkTMDbStart;
        private System.Windows.Forms.Label lblTMDbMessage;
        private System.Windows.Forms.GroupBox grbOptions;
        private System.Windows.Forms.CheckBox chkMarkAsWatched;
        private System.Windows.Forms.TextBox txtImdbUsername;
        private System.Windows.Forms.CheckBox chkImdbWatchlist;
        private System.Windows.Forms.RadioButton rdnImdbUsername;
        private System.Windows.Forms.RadioButton rdnImdbCSV;
        private System.Windows.Forms.Label lblIMDbDescription;
    }
}

