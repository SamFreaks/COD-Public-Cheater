using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

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
        }
    }
}