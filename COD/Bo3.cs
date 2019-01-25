using System;
using System.Windows.Forms;

namespace COD_Public_Cheater.COD
{
    public partial class Bo3 : Form
    {
        public Bo3()
        {
            InitializeComponent();
        }

        private void Bo3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void StartPBox_Click(object sender, EventArgs e)
        {
            var frm = new Start();
            frm.Show();
            Hide();
        }

        private void Bo3_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void DisableOnTop_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = !DisableOnTop.Checked;
        }
    }
}