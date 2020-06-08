using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Cashier
{
    public partial class loadingCashier : Form
    {
        public loadingCashier()
        {
            InitializeComponent();
        }

        private void loadingCashier_Load(object sender, EventArgs e)
        {

            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
        }
    }
}
