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
    public partial class CashierDashboard : Form
    {
        globalVariables gv = new globalVariables();
        YearController yearController = new YearController();
        AuditTrailControl auditTrailControl = new AuditTrailControl();
        loginController controller = new loginController();
        public CashierDashboard()
        {
            InitializeComponent();
            label1.Text = UserLog.getRole();
            label5.Text = UserLog.getUserName();
            timer1.Start();
            label6.Text = yearController.getSyActivated();
        }

        private void CashierDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Records fr1 = new Records();
            fr1.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult form1 = MessageBox.Show("Do you really want to Logout",
                              "Exit", MessageBoxButtons.YesNo);


            if (form1 == DialogResult.Yes)
            {
                auditTrailControl.addAudit(label7.Text, UserLog.getUserName() + "Has Logged-out");
                controller.setOffline(UserLog.getUserId());
                this.Hide();
                Login frm = new Login();
                frm.Show();
            }
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment fr1 = new Payment();
            fr1.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime my = DateTimeOffset.Now.DateTime.ToLocalTime().ToUniversalTime();


            DateTime mys = DateTimeOffset.Now.UtcDateTime.ToLocalTime();


            label7.Text = my.ToString("MM/dd/yyyy  hh:mm:ss tt");

            timer1.Enabled = true;
        }
    }
}
