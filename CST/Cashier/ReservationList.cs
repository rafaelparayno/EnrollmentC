using CST.Models;
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
    public partial class ReservationList : Form
    {
        StudentReserveController studentReserveController = new StudentReserveController();
        public ReservationList()
        {
            InitializeComponent();
        }

        private void ReservationList_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void refreshGrid()
        {
            studentReserveController.fillGrid(ref dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CashierDashboard frm = new CashierDashboard();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentReserveController.fillGridSearchSno(ref dataGridView1, txtUsername.Text.Trim());
        }
    }
}
