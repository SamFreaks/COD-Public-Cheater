using System.Windows.Forms;

namespace COD_Public_Cheater.COD
{
    public partial class Mw1 : Form
    {
        public Mw1()
        {
            InitializeComponent();
        }

        private void Mw1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void StartPBox_Click(object sender, System.EventArgs e)
        {
            var frm = new Start();
            frm.Show();
            Hide();
        }
    }
}