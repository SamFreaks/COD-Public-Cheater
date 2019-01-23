using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using COD_Public_Cheater.COD;

namespace COD_Public_Cheater
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            StartLoad();
            TopMost = true;
        }

        private void StartLoad()
        {
            FlashLinkLblTimer.Enabled = true;
            FlashLinkLblTimer.Start();
        }

        private void WelcomeLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (WelcomeLinkLbl.Text == @"Project COD Public Cheater")
            {
                Process.Start(@"https://github.com/ktownmods/COD-Public-Cheater");
                WelcomeLinkLbl.Text = @"Thanks for visiting";
            }
            else
            {
                WelcomeLinkLbl.Text = @"Project COD Public Cheater";
            }
        }

        private void FlashLinkLblTimer_Tick(object sender, EventArgs e)
        {
            var labelcolor = new Random();
            var r = labelcolor.Next(0, 255);
            var g = labelcolor.Next(0, 255);
            var b = labelcolor.Next(0, 255);
            var a = labelcolor.Next(0, 255);
            WelcomeLinkLbl.LinkColor = Color.FromArgb(r, g, b, a);
            GitHubLinkLbl.LinkColor = Color.FromArgb(r, g, b, a);
        }

        private void DisableFlash_CheckedChanged(object sender, EventArgs e)
        {
            if (DisableFlash.Checked)
            {
                FlashLinkLblTimer.Stop();
                WelcomeLinkLbl.LinkColor = Color.FromArgb(0, 0, 255);
                GitHubLinkLbl.LinkColor = Color.FromArgb(0, 0, 255);
            }
            else
            {
                FlashLinkLblTimer.Start();
            }
        }

        private void Mw1_Click(object sender, EventArgs e)
        {
            var frm = new Mw1();
            frm.Show();
            Hide();
        }

        private void Mw2PBox_Click(object sender, EventArgs e)
        {
            var frm = new Mw2();
            frm.Show();
            Hide();
        }

        private void Mw3PBox_Click(object sender, EventArgs e)
        {
            var frm = new Mw3();
            frm.Show();
            Hide();
        }

        private void Bo1PBox_Click(object sender, EventArgs e)
        {
            var frm = new Bo1();
            frm.Show();
            Hide();
        }

        private void Bo2PBox_Click(object sender, EventArgs e)
        {
            var frm = new Bo2();
            frm.Show();
            Hide();
        }

        private void Bo3PBox_Click(object sender, EventArgs e)
        {
            var frm = new Bo1();
            frm.Show();
            Hide();
        }

        private void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void GitHubLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (GitHubLinkLbl.Text == @"My GitHub")
            {
                Process.Start(@"https://github.com/ktownmods");
                GitHubLinkLbl.Location = new Point(653, 9);
                GitHubLinkLbl.Text = @"Thanks for visiting";
            }
            else
            {
                GitHubLinkLbl.Location = new Point(704, 9);
                GitHubLinkLbl.Text = @"My GitHub";
            }
        }

        private void DisableOnTop_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = !DisableOnTop.Checked;
        }

        private void BugLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // ReSharper disable once ConvertToConstant.Local
            var dr = new DialogResult();
            MessageBox.Show(@"", @"", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                (MessageBoxOptions) 0x40000);
            if (dr == DialogResult.Yes) Process.Start(@"https://github.com/ktownmods/COD-Public-Cheater/issues/new");
        }
    }
}