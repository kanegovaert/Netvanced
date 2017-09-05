using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net;

namespace Netvanced_Proxy_Tool
{
    /// <summary>
    /// Title: Netvanced Proxy Scraper
    /// Description: An advanced proxy tool for all your needs!
    /// Developed by: https://www.github.com/Kaneke
    /// </summary>


    public partial class NetvancedForm : Form
    {
        // Instances
        Defaults _Def = new Defaults();

        // Variables
        int ProxyAmount, AmountOfPages, ThreadCount;
        string CurrentlyScrapingPage;
        bool Status_Gathering;

        // Delegates
        public NetvancedForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        //___________________________________________________________//
        // All the background workers in NetvancedForm
        // Description: For all the background tasks...
        //___________________________________________________________//
        private void backgroundGatherer_DoWork(object sender, DoWorkEventArgs e)
        {
            Status_Gathering = true;
            ThreadCount = Convert.ToInt32(NUD_ThreadCount.Value);
            ThreadPool.SetMinThreads(ThreadCount, ThreadCount);
            ThreadPool.SetMaxThreads(ThreadCount, ThreadCount);
            ServicePointManager.DefaultConnectionLimit = ThreadCount;
            ServicePointManager.Expect100Continue = true;
            foreach (string Link in TB_Sources.Lines)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(GatherProxies), Link);
            }
        }

        private void backgroundGatherer_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundGatherer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        //___________________________________________________________//
        // All the simple functions in NetvancedForm
        // Description: Simple but functional...
        //___________________________________________________________//
 
        private void CreateLog(string TheLog, bool? Success)
        {
            if ((bool)Success)
            {
                LB_Logs.Items.Add("[+] " + TheLog);
            }
            else if ((bool)!Success)
            {
                LB_Logs.Items.Add("[-] " + TheLog);
            }
            else
            {
                LB_Logs.Items.Add("[%] " + TheLog);
            } 
        }
        private void StartGatherEvent()
        {
            if (NUD_ThreadCount.Value <= 0)
            {
                CreateLog("Cannot start gatehring \nwith zero threads!", false);
                backgroundGatherer.CancelAsync();
            }
            else
            {
                backgroundGatherer.RunWorkerAsync();
            }
        }
        //___________________________________________________________//
        // All the more complex functions in NetvancedForm
        // Description: To get everything done and make this useful...
        //___________________________________________________________//
        private void GatherProxies(object Gathering)
        {
                System.Net.WebClient _WC = new System.Net.WebClient();
                List<string> TempProxies = new List<string>();
            {
                try
                {
                    foreach (string PageToScrape in TB_Sources.Lines)
                    {
                        string PageSource = _WC.DownloadString(PageToScrape);
                        CurrentlyScrapingPage = PageToScrape;

                        MatchCollection _MC = _Def.REGEX.Matches(PageSource);
                        foreach (Match Match in _MC)
                        {
                            LB_GatheredProxies.Items.Add(Match.ToString());
                            ProxyAmount = Convert.ToInt32(LB_GatheredProxies.Items.Count);
                        }
                        if (!LB_Logs.Items.Contains(PageToScrape))
                        {
                            CreateLog("Scraped: " + PageToScrape, true);
                        }
                    }
                }
                catch (Exception) {
                    CreateLog("Dead link: " + CurrentlyScrapingPage, false);
                }
            }
        }

        //___________________________________________________________//
        // All the button events in NetvancedForm
        // Description: To make everything functional in the UI
        //___________________________________________________________//

        private void BTN_ClearLogs_Click(object sender, EventArgs e)
        {
            LB_Logs.Items.Clear();
            CreateLog("Logs have been cleared!", true);
        }
        private void BTN_Gather_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string Line in TB_Sources.Lines)
                {
                    AmountOfPages++;
                }
                CreateLog("Going to scrape " + AmountOfPages + " pages", true);
                backgroundGatherer.RunWorkerAsync();
            } catch (Exception)
            {
                CreateLog("Engine is currently gathering!", false);
            }
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            int ClearedProxies = LB_GatheredProxies.Items.Count;
            LB_GatheredProxies.Items.Clear();
            CreateLog(+ ClearedProxies +" Proxies have been cleared!", true);
        }

        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            SaveProxies(LB_GatheredProxies);
        }

        private void SaveProxies(ListBox LB_ItemsToSave)
        {
            if (this.LB_GatheredProxies.Items != null)
            {
                if (this.LB_GatheredProxies.Items != null)
                {
                    SaveFileDialog _SFD = new SaveFileDialog();
                    _SFD.FileName = "Netvanced Proxies.txt";
                    _SFD.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

                    if (_SFD.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter _SW = new StreamWriter(_SFD.FileName))
                            foreach (string Item in this.LB_GatheredProxies.Items)
                            {
                                _SW.WriteLine(Item);
                            }
                    }
                    CreateLog(this.LB_GatheredProxies.Items.Count + " Proxies have been saved!", true);
                }
                else
                {
                    CreateLog("Could not save proxies...", false);
                }
            }
            else
            {
                CreateLog("Cannot save zero proxies!", false);
            }
        }

        private void BTN_StopGathering_Click(object sender, EventArgs e)
        {
            Status_Gathering = false;
            if (backgroundGatherer.IsBusy)
            {
                backgroundGatherer.CancelAsync();
                CreateLog("Stopped gathering successfully!", true);
            }
            else {
                CreateLog("Not gathering!", false);
            }
        }

        private void BTN_ScrapeProxies_Click(object sender, EventArgs e)
        {
            MatchCollection _MC = _Def.REGEX.Matches(TB_ScrapeInput.Text);
            foreach (Match Match in _MC)
            {
                LB_ScrapedProxies.Items.Add(Match.ToString());
            }
            CreateLog("Scraped " + LB_ScrapedProxies.Items.Count, true);
        }

        private void BTN_SaveScrapedProxies_Click(object sender, EventArgs e)
        {
            SaveProxies(LB_ScrapedProxies);
        }

        private void BTN_ClearScrapedProxies_Click(object sender, EventArgs e)
        {
            LB_ScrapedProxies.Items.Clear();
        }

        private void BTN_Import_Click(object sender, EventArgs e)
        {
            int ProxyCount = 0;
            ListViewItem ProxyCountItem;
            ListViewItem.ListViewSubItem Proxies, TimeoutValue;

            foreach (string Proxy in TB_ProxiesToCheck.Lines)
            {
                ProxyCount++;
                //LV_ProxyChecking.Items.Add(ProxyCountItem);
            }
        }

        private void BTN_Check_Click(object sender, EventArgs e)
        {

        }

        //___________________________________________________________//
        // All the other events in the NetvancedForm
        // Description: To polish everything else in the form...
        //___________________________________________________________//
        private void TB_Sources_TextChanged(object sender, EventArgs e)
        {
            foreach (string Source in TB_Sources.Lines)
            {
                _Def.Sources.Add(Source);
            }
            CreateLog(_Def.Sources.Count + " Sources have been succesfully \nadded", true);
        }

        private void NetvancedForm_Load(object sender, EventArgs e)
        {
            if(TB_Sources.Text != null)
            {
                foreach (string Source in TB_Sources.Lines)
                {
                    _Def.Sources.Add(Source);
                }
                CreateLog(+ _Def.Sources.Count + " Sources have been succesfully \nadded", true);
            }
            else
            {
                CreateLog("No sources could be loaded, please load sources yourself!", false);
            }
        }

    }
}
