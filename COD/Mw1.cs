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
    }
}