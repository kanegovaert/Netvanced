namespace Netvanced_Proxy_Tool
{
    partial class NetvancedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetvancedForm));
            this.backgroundGatherer = new System.ComponentModel.BackgroundWorker();
            this.TC_MainTabControl = new System.Windows.Forms.TabControl();
            this.TP_Gatherer = new System.Windows.Forms.TabPage();
            this.GP_GatherProxies = new System.Windows.Forms.GroupBox();
            this.BTN_StopGathering = new System.Windows.Forms.Button();
            this.NUD_ThreadCount = new System.Windows.Forms.NumericUpDown();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.BTN_Stop = new System.Windows.Forms.Button();
            this.LB_GatheredProxies = new System.Windows.Forms.ListBox();
            this.TP_Scraper = new System.Windows.Forms.TabPage();
            this.BTN_SaveScrapedProxies = new System.Windows.Forms.Button();
            this.BTN_ClearScrapedProxies = new System.Windows.Forms.Button();
            this.BTN_ScrapeProxies = new System.Windows.Forms.Button();
            this.LB_ScrapedProxies = new System.Windows.Forms.ListBox();
            this.TB_ScrapeInput = new System.Windows.Forms.TextBox();
            this.TP_Checker = new System.Windows.Forms.TabPage();
            this.BTN_Import = new System.Windows.Forms.Button();
            this.BTN_ClearCheckedProxies = new System.Windows.Forms.Button();
            this.BTN_CheckProxies = new System.Windows.Forms.Button();
            this.BTN_SaveProxies = new System.Windows.Forms.Button();
            this.TB_ProxiesToCheck = new System.Windows.Forms.TextBox();
            this.LV_ProxyChecking = new System.Windows.Forms.ListView();
            this.CH_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Proxy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Timeout = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TP_Sources = new System.Windows.Forms.TabPage();
            this.GB_SourceAdder = new System.Windows.Forms.GroupBox();
            this.TB_Sources = new System.Windows.Forms.TextBox();
            this.TP_Credits = new System.Windows.Forms.TabPage();
            this.LL_LinkToGithub = new System.Windows.Forms.LinkLabel();
            this.BTN_ClearLogs = new System.Windows.Forms.Button();
            this.LBL_Netvanced = new System.Windows.Forms.Label();
            this.LB_Logs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TC_MainTabControl.SuspendLayout();
            this.TP_Gatherer.SuspendLayout();
            this.GP_GatherProxies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_ThreadCount)).BeginInit();
            this.TP_Scraper.SuspendLayout();
            this.TP_Checker.SuspendLayout();
            this.TP_Sources.SuspendLayout();
            this.GB_SourceAdder.SuspendLayout();
            this.TP_Credits.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundGatherer
            // 
            this.backgroundGatherer.WorkerReportsProgress = true;
            this.backgroundGatherer.WorkerSupportsCancellation = true;
            this.backgroundGatherer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundGatherer_DoWork);
            this.backgroundGatherer.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundGatherer_ProgressChanged);
            this.backgroundGatherer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundGatherer_RunWorkerCompleted);
            // 
            // TC_MainTabControl
            // 
            this.TC_MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TC_MainTabControl.Controls.Add(this.TP_Gatherer);
            this.TC_MainTabControl.Controls.Add(this.TP_Scraper);
            this.TC_MainTabControl.Controls.Add(this.TP_Checker);
            this.TC_MainTabControl.Controls.Add(this.TP_Sources);
            this.TC_MainTabControl.Controls.Add(this.TP_Credits);
            this.TC_MainTabControl.Location = new System.Drawing.Point(13, 26);
            this.TC_MainTabControl.Name = "TC_MainTabControl";
            this.TC_MainTabControl.SelectedIndex = 0;
            this.TC_MainTabControl.Size = new System.Drawing.Size(794, 543);
            this.TC_MainTabControl.TabIndex = 0;
            // 
            // TP_Gatherer
            // 
            this.TP_Gatherer.Controls.Add(this.GP_GatherProxies);
            this.TP_Gatherer.Location = new System.Drawing.Point(4, 25);
            this.TP_Gatherer.Name = "TP_Gatherer";
            this.TP_Gatherer.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Gatherer.Size = new System.Drawing.Size(786, 514);
            this.TP_Gatherer.TabIndex = 0;
            this.TP_Gatherer.Text = "Gatherer";
            this.TP_Gatherer.UseVisualStyleBackColor = true;
            // 
            // GP_GatherProxies
            // 
            this.GP_GatherProxies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GP_GatherProxies.Controls.Add(this.BTN_StopGathering);
            this.GP_GatherProxies.Controls.Add(this.NUD_ThreadCount);
            this.GP_GatherProxies.Controls.Add(this.BTN_Clear);
            this.GP_GatherProxies.Controls.Add(this.BTN_Save);
            this.GP_GatherProxies.Controls.Add(this.BTN_Stop);
            this.GP_GatherProxies.Controls.Add(this.LB_GatheredProxies);
            this.GP_GatherProxies.Location = new System.Drawing.Point(6, 6);
            this.GP_GatherProxies.Name = "GP_GatherProxies";
            this.GP_GatherProxies.Size = new System.Drawing.Size(774, 502);
            this.GP_GatherProxies.TabIndex = 0;
            this.GP_GatherProxies.TabStop = false;
            this.GP_GatherProxies.Text = "Gather proxies";
            // 
            // BTN_StopGathering
            // 
            this.BTN_StopGathering.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_StopGathering.Location = new System.Drawing.Point(626, 175);
            this.BTN_StopGathering.Name = "BTN_StopGathering";
            this.BTN_StopGathering.Size = new System.Drawing.Size(142, 36);
            this.BTN_StopGathering.TabIndex = 8;
            this.BTN_StopGathering.Text = "Stop";
            this.BTN_StopGathering.UseVisualStyleBackColor = true;
            this.BTN_StopGathering.Click += new System.EventHandler(this.BTN_StopGathering_Click);
            // 
            // NUD_ThreadCount
            // 
            this.NUD_ThreadCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NUD_ThreadCount.Location = new System.Drawing.Point(626, 21);
            this.NUD_ThreadCount.Name = "NUD_ThreadCount";
            this.NUD_ThreadCount.Size = new System.Drawing.Size(142, 22);
            this.NUD_ThreadCount.TabIndex = 7;
            this.NUD_ThreadCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Clear.Location = new System.Drawing.Point(626, 49);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(142, 36);
            this.BTN_Clear.TabIndex = 3;
            this.BTN_Clear.Text = "Save";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // BTN_Save
            // 
            this.BTN_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Save.Location = new System.Drawing.Point(626, 91);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(142, 36);
            this.BTN_Save.TabIndex = 2;
            this.BTN_Save.Text = "Clear";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // BTN_Stop
            // 
            this.BTN_Stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Stop.Location = new System.Drawing.Point(626, 133);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(142, 36);
            this.BTN_Stop.TabIndex = 1;
            this.BTN_Stop.Text = "Gather";
            this.BTN_Stop.UseVisualStyleBackColor = true;
            this.BTN_Stop.Click += new System.EventHandler(this.BTN_Gather_Click);
            // 
            // LB_GatheredProxies
            // 
            this.LB_GatheredProxies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_GatheredProxies.FormattingEnabled = true;
            this.LB_GatheredProxies.ItemHeight = 16;
            this.LB_GatheredProxies.Location = new System.Drawing.Point(6, 21);
            this.LB_GatheredProxies.Name = "LB_GatheredProxies";
            this.LB_GatheredProxies.Size = new System.Drawing.Size(614, 468);
            this.LB_GatheredProxies.TabIndex = 0;
            // 
            // TP_Scraper
            // 
            this.TP_Scraper.Controls.Add(this.BTN_SaveScrapedProxies);
            this.TP_Scraper.Controls.Add(this.BTN_ClearScrapedProxies);
            this.TP_Scraper.Controls.Add(this.BTN_ScrapeProxies);
            this.TP_Scraper.Controls.Add(this.LB_ScrapedProxies);
            this.TP_Scraper.Controls.Add(this.TB_ScrapeInput);
            this.TP_Scraper.Location = new System.Drawing.Point(4, 25);
            this.TP_Scraper.Name = "TP_Scraper";
            this.TP_Scraper.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Scraper.Size = new System.Drawing.Size(786, 514);
            this.TP_Scraper.TabIndex = 1;
            this.TP_Scraper.Text = "Scraper";
            this.TP_Scraper.UseVisualStyleBackColor = true;
            // 
            // BTN_SaveScrapedProxies
            // 
            this.BTN_SaveScrapedProxies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_SaveScrapedProxies.Location = new System.Drawing.Point(490, 472);
            this.BTN_SaveScrapedProxies.Name = "BTN_SaveScrapedProxies";
            this.BTN_SaveScrapedProxies.Size = new System.Drawing.Size(142, 36);
            this.BTN_SaveScrapedProxies.TabIndex = 6;
            this.BTN_SaveScrapedProxies.Text = "Save";
            this.BTN_SaveScrapedProxies.UseVisualStyleBackColor = true;
            this.BTN_SaveScrapedProxies.Click += new System.EventHandler(this.BTN_SaveScrapedProxies_Click);
            // 
            // BTN_ClearScrapedProxies
            // 
            this.BTN_ClearScrapedProxies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_ClearScrapedProxies.Location = new System.Drawing.Point(6, 472);
            this.BTN_ClearScrapedProxies.Name = "BTN_ClearScrapedProxies";
            this.BTN_ClearScrapedProxies.Size = new System.Drawing.Size(142, 36);
            this.BTN_ClearScrapedProxies.TabIndex = 5;
            this.BTN_ClearScrapedProxies.Text = "Clear";
            this.BTN_ClearScrapedProxies.UseVisualStyleBackColor = true;
            this.BTN_ClearScrapedProxies.Click += new System.EventHandler(this.BTN_ClearScrapedProxies_Click);
            // 
            // BTN_ScrapeProxies
            // 
            this.BTN_ScrapeProxies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_ScrapeProxies.Location = new System.Drawing.Point(638, 472);
            this.BTN_ScrapeProxies.Name = "BTN_ScrapeProxies";
            this.BTN_ScrapeProxies.Size = new System.Drawing.Size(142, 36);
            this.BTN_ScrapeProxies.TabIndex = 4;
            this.BTN_ScrapeProxies.Text = "Scrape";
            this.BTN_ScrapeProxies.UseVisualStyleBackColor = true;
            this.BTN_ScrapeProxies.Click += new System.EventHandler(this.BTN_ScrapeProxies_Click);
            // 
            // LB_ScrapedProxies
            // 
            this.LB_ScrapedProxies.FormattingEnabled = true;
            this.LB_ScrapedProxies.ItemHeight = 16;
            this.LB_ScrapedProxies.Location = new System.Drawing.Point(6, 250);
            this.LB_ScrapedProxies.Name = "LB_ScrapedProxies";
            this.LB_ScrapedProxies.Size = new System.Drawing.Size(774, 212);
            this.LB_ScrapedProxies.TabIndex = 1;
            // 
            // TB_ScrapeInput
            // 
            this.TB_ScrapeInput.Location = new System.Drawing.Point(6, 9);
            this.TB_ScrapeInput.Multiline = true;
            this.TB_ScrapeInput.Name = "TB_ScrapeInput";
            this.TB_ScrapeInput.Size = new System.Drawing.Size(774, 235);
            this.TB_ScrapeInput.TabIndex = 0;
            this.TB_ScrapeInput.Text = resources.GetString("TB_ScrapeInput.Text");
            // 
            // TP_Checker
            // 
            this.TP_Checker.Controls.Add(this.BTN_Import);
            this.TP_Checker.Controls.Add(this.BTN_ClearCheckedProxies);
            this.TP_Checker.Controls.Add(this.BTN_CheckProxies);
            this.TP_Checker.Controls.Add(this.BTN_SaveProxies);
            this.TP_Checker.Controls.Add(this.TB_ProxiesToCheck);
            this.TP_Checker.Controls.Add(this.LV_ProxyChecking);
            this.TP_Checker.Location = new System.Drawing.Point(4, 25);
            this.TP_Checker.Name = "TP_Checker";
            this.TP_Checker.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Checker.Size = new System.Drawing.Size(786, 514);
            this.TP_Checker.TabIndex = 2;
            this.TP_Checker.Text = "Checker";
            this.TP_Checker.UseVisualStyleBackColor = true;
            // 
            // BTN_Import
            // 
            this.BTN_Import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Import.Location = new System.Drawing.Point(490, 473);
            this.BTN_Import.Name = "BTN_Import";
            this.BTN_Import.Size = new System.Drawing.Size(142, 36);
            this.BTN_Import.TabIndex = 7;
            this.BTN_Import.Text = "Import";
            this.BTN_Import.UseVisualStyleBackColor = true;
            this.BTN_Import.Click += new System.EventHandler(this.BTN_Import_Click);
            // 
            // BTN_ClearCheckedProxies
            // 
            this.BTN_ClearCheckedProxies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_ClearCheckedProxies.Location = new System.Drawing.Point(155, 473);
            this.BTN_ClearCheckedProxies.Name = "BTN_ClearCheckedProxies";
            this.BTN_ClearCheckedProxies.Size = new System.Drawing.Size(142, 36);
            this.BTN_ClearCheckedProxies.TabIndex = 6;
            this.BTN_ClearCheckedProxies.Text = "Clear";
            this.BTN_ClearCheckedProxies.UseVisualStyleBackColor = true;
            this.BTN_ClearCheckedProxies.Click += new System.EventHandler(this.BTN_ClearCheckedProxies_Click);
            // 
            // BTN_CheckProxies
            // 
            this.BTN_CheckProxies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_CheckProxies.Location = new System.Drawing.Point(638, 473);
            this.BTN_CheckProxies.Name = "BTN_CheckProxies";
            this.BTN_CheckProxies.Size = new System.Drawing.Size(142, 36);
            this.BTN_CheckProxies.TabIndex = 5;
            this.BTN_CheckProxies.Text = "Check";
            this.BTN_CheckProxies.UseVisualStyleBackColor = true;
            this.BTN_CheckProxies.Click += new System.EventHandler(this.BTN_CheckProxies_Click);
            // 
            // BTN_SaveProxies
            // 
            this.BTN_SaveProxies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_SaveProxies.Location = new System.Drawing.Point(7, 473);
            this.BTN_SaveProxies.Name = "BTN_SaveProxies";
            this.BTN_SaveProxies.Size = new System.Drawing.Size(142, 36);
            this.BTN_SaveProxies.TabIndex = 4;
            this.BTN_SaveProxies.Text = "Save";
            this.BTN_SaveProxies.UseVisualStyleBackColor = true;
            this.BTN_SaveProxies.Click += new System.EventHandler(this.BTN_SaveProxies_Click);
            // 
            // TB_ProxiesToCheck
            // 
            this.TB_ProxiesToCheck.Location = new System.Drawing.Point(7, 7);
            this.TB_ProxiesToCheck.Multiline = true;
            this.TB_ProxiesToCheck.Name = "TB_ProxiesToCheck";
            this.TB_ProxiesToCheck.Size = new System.Drawing.Size(315, 462);
            this.TB_ProxiesToCheck.TabIndex = 1;
            // 
            // LV_ProxyChecking
            // 
            this.LV_ProxyChecking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_Number,
            this.CH_Proxy,
            this.CH_Timeout});
            this.LV_ProxyChecking.Location = new System.Drawing.Point(328, 6);
            this.LV_ProxyChecking.Name = "LV_ProxyChecking";
            this.LV_ProxyChecking.Size = new System.Drawing.Size(452, 463);
            this.LV_ProxyChecking.TabIndex = 0;
            this.LV_ProxyChecking.UseCompatibleStateImageBehavior = false;
            this.LV_ProxyChecking.View = System.Windows.Forms.View.Details;
            // 
            // CH_Number
            // 
            this.CH_Number.Text = "#";
            this.CH_Number.Width = 75;
            // 
            // CH_Proxy
            // 
            this.CH_Proxy.Text = "Proxy";
            this.CH_Proxy.Width = 206;
            // 
            // CH_Timeout
            // 
            this.CH_Timeout.Text = "Timeout";
            this.CH_Timeout.Width = 116;
            // 
            // TP_Sources
            // 
            this.TP_Sources.Controls.Add(this.GB_SourceAdder);
            this.TP_Sources.Location = new System.Drawing.Point(4, 25);
            this.TP_Sources.Name = "TP_Sources";
            this.TP_Sources.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Sources.Size = new System.Drawing.Size(786, 514);
            this.TP_Sources.TabIndex = 3;
            this.TP_Sources.Text = "Sources";
            this.TP_Sources.UseVisualStyleBackColor = true;
            // 
            // GB_SourceAdder
            // 
            this.GB_SourceAdder.Controls.Add(this.TB_Sources);
            this.GB_SourceAdder.Location = new System.Drawing.Point(6, 6);
            this.GB_SourceAdder.Name = "GB_SourceAdder";
            this.GB_SourceAdder.Size = new System.Drawing.Size(807, 491);
            this.GB_SourceAdder.TabIndex = 0;
            this.GB_SourceAdder.TabStop = false;
            this.GB_SourceAdder.Text = "Source adder";
            // 
            // TB_Sources
            // 
            this.TB_Sources.Location = new System.Drawing.Point(6, 21);
            this.TB_Sources.Multiline = true;
            this.TB_Sources.Name = "TB_Sources";
            this.TB_Sources.Size = new System.Drawing.Size(722, 464);
            this.TB_Sources.TabIndex = 0;
            this.TB_Sources.Text = resources.GetString("TB_Sources.Text");
            this.TB_Sources.TextChanged += new System.EventHandler(this.TB_Sources_TextChanged);
            // 
            // TP_Credits
            // 
            this.TP_Credits.Controls.Add(this.label2);
            this.TP_Credits.Controls.Add(this.label1);
            this.TP_Credits.Controls.Add(this.LL_LinkToGithub);
            this.TP_Credits.Location = new System.Drawing.Point(4, 25);
            this.TP_Credits.Name = "TP_Credits";
            this.TP_Credits.Size = new System.Drawing.Size(786, 514);
            this.TP_Credits.TabIndex = 5;
            this.TP_Credits.Text = "Credits";
            this.TP_Credits.UseVisualStyleBackColor = true;
            // 
            // LL_LinkToGithub
            // 
            this.LL_LinkToGithub.AutoSize = true;
            this.LL_LinkToGithub.Location = new System.Drawing.Point(84, 29);
            this.LL_LinkToGithub.Name = "LL_LinkToGithub";
            this.LL_LinkToGithub.Size = new System.Drawing.Size(96, 17);
            this.LL_LinkToGithub.TabIndex = 1;
            this.LL_LinkToGithub.TabStop = true;
            this.LL_LinkToGithub.Text = "Kane Govaert";
            this.LL_LinkToGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_LinkToGithub_LinkClicked);
            // 
            // BTN_ClearLogs
            // 
            this.BTN_ClearLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_ClearLogs.Location = new System.Drawing.Point(813, 520);
            this.BTN_ClearLogs.Name = "BTN_ClearLogs";
            this.BTN_ClearLogs.Size = new System.Drawing.Size(312, 45);
            this.BTN_ClearLogs.TabIndex = 2;
            this.BTN_ClearLogs.Text = "Clear";
            this.BTN_ClearLogs.UseVisualStyleBackColor = true;
            this.BTN_ClearLogs.Click += new System.EventHandler(this.BTN_ClearLogs_Click);
            // 
            // LBL_Netvanced
            // 
            this.LBL_Netvanced.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Netvanced.AutoSize = true;
            this.LBL_Netvanced.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Netvanced.Location = new System.Drawing.Point(867, 1);
            this.LBL_Netvanced.Name = "LBL_Netvanced";
            this.LBL_Netvanced.Size = new System.Drawing.Size(258, 56);
            this.LBL_Netvanced.TabIndex = 3;
            this.LBL_Netvanced.Text = "Netvanced";
            // 
            // LB_Logs
            // 
            this.LB_Logs.FormattingEnabled = true;
            this.LB_Logs.ItemHeight = 16;
            this.LB_Logs.Location = new System.Drawing.Point(814, 57);
            this.LB_Logs.Name = "LB_Logs";
            this.LB_Logs.Size = new System.Drawing.Size(311, 452);
            this.LB_Logs.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project by:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Made with <3";
            // 
            // NetvancedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 581);
            this.Controls.Add(this.LB_Logs);
            this.Controls.Add(this.LBL_Netvanced);
            this.Controls.Add(this.BTN_ClearLogs);
            this.Controls.Add(this.TC_MainTabControl);
            this.MinimumSize = new System.Drawing.Size(1155, 596);
            this.Name = "NetvancedForm";
            this.ShowIcon = false;
            this.Text = "Netvanced Proxy Tool";
            this.Load += new System.EventHandler(this.NetvancedForm_Load);
            this.TC_MainTabControl.ResumeLayout(false);
            this.TP_Gatherer.ResumeLayout(false);
            this.GP_GatherProxies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_ThreadCount)).EndInit();
            this.TP_Scraper.ResumeLayout(false);
            this.TP_Scraper.PerformLayout();
            this.TP_Checker.ResumeLayout(false);
            this.TP_Checker.PerformLayout();
            this.TP_Sources.ResumeLayout(false);
            this.GB_SourceAdder.ResumeLayout(false);
            this.GB_SourceAdder.PerformLayout();
            this.TP_Credits.ResumeLayout(false);
            this.TP_Credits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundGatherer;
        private System.Windows.Forms.TabControl TC_MainTabControl;
        private System.Windows.Forms.TabPage TP_Gatherer;
        private System.Windows.Forms.TabPage TP_Scraper;
        private System.Windows.Forms.TabPage TP_Checker;
        private System.Windows.Forms.TabPage TP_Sources;
        private System.Windows.Forms.TabPage TP_Credits;
        private System.Windows.Forms.Button BTN_ClearLogs;
        private System.Windows.Forms.GroupBox GB_SourceAdder;
        private System.Windows.Forms.TextBox TB_Sources;
        private System.Windows.Forms.GroupBox GP_GatherProxies;
        private System.Windows.Forms.NumericUpDown NUD_ThreadCount;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Button BTN_Stop;
        private System.Windows.Forms.ListBox LB_GatheredProxies;
        private System.Windows.Forms.Label LBL_Netvanced;
        private System.Windows.Forms.Button BTN_StopGathering;
        private System.Windows.Forms.Button BTN_SaveScrapedProxies;
        private System.Windows.Forms.Button BTN_ClearScrapedProxies;
        private System.Windows.Forms.Button BTN_ScrapeProxies;
        private System.Windows.Forms.ListBox LB_ScrapedProxies;
        private System.Windows.Forms.TextBox TB_ScrapeInput;
        private System.Windows.Forms.ListBox LB_Logs;
        private System.Windows.Forms.TextBox TB_ProxiesToCheck;
        private System.Windows.Forms.ListView LV_ProxyChecking;
        private System.Windows.Forms.ColumnHeader CH_Number;
        private System.Windows.Forms.ColumnHeader CH_Proxy;
        private System.Windows.Forms.ColumnHeader CH_Timeout;
        private System.Windows.Forms.Button BTN_Import;
        private System.Windows.Forms.Button BTN_ClearCheckedProxies;
        private System.Windows.Forms.Button BTN_CheckProxies;
        private System.Windows.Forms.Button BTN_SaveProxies;
        private System.Windows.Forms.LinkLabel LL_LinkToGithub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

