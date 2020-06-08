using CST.Cashier;
using CST.Models;
using CST.Teacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST
{
    public partial class Generated : Form
    {
        UserController user = new UserController();



        bool isHide = true;
        string role = "";
        public Generated(string role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                string userId = UserLog.getUserId();
                user.ChangedPass(userId, txtPassword.Text.Trim());
                MessageBox.Show("Succesfully Changed Password");

                if(role == "System Admin")
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }else if(role == "Enrollment Admin")
                {
                    EnrollmentAdmin admin = new EnrollmentAdmin();
                    admin.Show();
                    this.Hide();

                }else if(role == "Cashier")
                {
                    CashierDashboard cash = new CashierDashboard();
                    this.Hide();
                    cash.Show();

                }else if(role == "Registrar")
                {
                    RegistrarForm registrarForm = new RegistrarForm();
                    this.Hide();
                    registrarForm.Show();

                }
                else
                {
                    TeacherFrm frm = new TeacherFrm();
                    frm.Show();
                    this.Hide();
                }
            }
            
        }

        private void Generated_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isHide)
            {
                button1.Text = "Show";
                isHide = true;
                txtPassword.PasswordChar = '*';
             
            }
            else
            {
                button1.Text = "Hide";
                isHide = false;
                txtPassword.PasswordChar = '\0';
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text.Length < 8)
            {
                label1.Visible = true;
                label1.Text = "Minimum password Length 8";
                label1.ForeColor = Color.IndianRed;
            }
            else
            {
                label1.ForeColor = Color.ForestGreen;
                label1.Text = "Password Length is okay";
            }
            txtConfirmHandler();
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            txtConfirmHandler();
        }

        private void txtConfirmHandler()
        {
            if (txtPassword.Text == txtConfirm.Text)
            {
                label2.Visible = true;
                label2.Text = "Password Match";
                label2.ForeColor = Color.ForestGreen;
            }
            else
            {
                label2.Visible = true;
                label2.Text = "Password not match";
                label2.ForeColor = Color.IndianRed;
            }

            if(txtConfirm.Text.Length == 0)
            {
                label2.Visible = false;
            }
        }


        private bool isValid()
        {
            bool isValid = true;

            isValid = !(txtPassword.Text.Trim() == "") && isValid;

            isValid = (txtPassword.Text.Length >= 8) && isValid;

            isValid = (txtPassword.Text == txtConfirm.Text) && isValid;


            if (!isValid)
            {
                MessageBox.Show("Password is Not Valid", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            return isValid;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            string validKeys = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (validKeys.IndexOf(e.KeyChar) < 0 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
