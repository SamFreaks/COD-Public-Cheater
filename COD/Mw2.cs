using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COD_Public_Cheater.COD
{
    public partial class Mw2 : Form
    {
        public Mw2()
        {
            InitializeComponent();
        }

        private void Mw2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
