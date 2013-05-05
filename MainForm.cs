using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace LoLConnectionTool
{
    public partial class MainForm : Form
    {
        #region variables
        const string REBOOT_URL = "http://192.168.254.1/reboot.asp";
        #endregion
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void btnPing_Click(object sender, EventArgs e)
        {
            Ping pinger = new Ping();
            PingOptions pingOptions = new PingOptions();

            byte[] buffer = new byte[32];

            pingOptions.DontFragment = true;
            PingReply pingReply = pinger.Send("125.5.6.1");

            if (pingReply.Status == IPStatus.Success)
            {
                txtStatus.Text += Environment.NewLine +
                    string.Format("Reply from {0}: bytes={1} time={2}ms TTL={3}", pingReply.Address, pingReply.Buffer.Length, pingReply.RoundtripTime, pingReply.Options.Ttl);
            }
            else
            {
                txtStatus.Text += Environment.NewLine + "Destination host unreachable!";
            }
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            
            var lolClient = from Process p in Process.GetProcesses() where p.ProcessName.ToLower() == "lolclient" select p;
            var lolExe = from Process p in Process.GetProcesses() where p.ProcessName.ToLower() == "league of legends" select p;
            
            if ((lolClient.Count() > 0 || lolExe.Count() > 0) &&
                (MessageBox.Show("Are you sure you want to terminate LoL processes?",
                    "CONFIRM LOL TERMINATE",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes))
            {
                if (lolClient.Count() > 0)
                {
                    lolClient.First().Kill();
                    txtStatus.Text += Environment.NewLine +
                        "Sucessfully killed " + lolClient.First().ProcessName;
                }
                else
                {
                    txtStatus.Text += Environment.NewLine +
                    "Cannot find LoLClient in running processes.";
                }
                
                System.Threading.Thread.Sleep(1000);

                if (lolExe.Count() > 0)
                {
                    lolExe.First().Kill();
                    txtStatus.Text += Environment.NewLine +
                        "Sucessfully killed " + lolExe.First().ProcessName;
                }
                else
                {
                    txtStatus.Text += Environment.NewLine +
                        "Cannot find League of Legends in running processes.";
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStatus.Text = string.Empty;
        }

        private void webModem_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            if (webModem.Url.ToString() == REBOOT_URL)
            {
                HtmlDocument htmlDoc = webModem.Document;
                HtmlElementCollection buttons = htmlDoc.GetElementsByTagName("input");
                var resetButton = from HtmlElement element in htmlDoc.GetElementsByTagName("input")
                                  where element.Name == "reboot"
                                  select element;

                if (resetButton.Count() > 0)
                {
                    resetButton.First().InvokeMember("click");
                    timerCountdown.Enabled = true;
                    btnRestartModem.Enabled = false;
                    btnRestartModem.Text = "Restarting....";
                    webModem.AllowNavigation = false;
                }
                else
                {
                    MessageBox.Show("Cannot find the  reset button.",
                        "FAIL TO RESTART MODEM",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                webModem.AllowNavigation = false;
            }
        }

        private void btnRestartModem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to restart your modem?",
                "CONFIRM RESTART",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                webModem.AllowNavigation = true;
                webModem.Navigate(REBOOT_URL);
            }
            
            
        }

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            btnRestartModem.Enabled = true;
            btnRestartModem.Text = "Restart Modem";
            timerCountdown.Enabled = false;
        }
    }
}
