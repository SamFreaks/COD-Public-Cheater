using System;
using System.Windows.Forms;

namespace COD_Public_Cheater.COD
{
    public partial class Bo1 : Form
    {
        public Bo1()
        {
            InitializeComponent();
        }

        private void BO1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Bo1_Load(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void StartPBox_Click(object sender, EventArgs e)
        {
            var frm = new Start();
            frm.Show();
            Hide();
        }

        private void DisableOnTop_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = !DisableOnTop.Checked;
        }
    }
}
