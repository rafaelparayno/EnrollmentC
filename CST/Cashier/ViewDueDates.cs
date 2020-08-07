using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using CST.Models;

namespace CST.Cashier
{
    public partial class ViewDueDates : Form
    {
        CultureInfo provider = CultureInfo.InvariantCulture;
        StudentBalance StudentBalance = new StudentBalance();
        public ViewDueDates()
        {
            InitializeComponent();
        }

        private void ViewDueDates_Load(object sender, EventArgs e)
        {

        }


        private string setDueDates(string mod, string dateEnd, double payments)
        {
            string dues = "";
            string duess;
            DateTime date = DateTime.ParseExact(dateEnd, "dd/MM/yyyy", provider);
            DateTime dateEndPayment = DateTime.ParseExact(dateEnd, "dd/MM/yyyy", provider).AddMonths(9);

            dateEndPayment.AddMonths(9);
            switch (mod)
            {


                case "Semi-Annual":
                    date = date.AddMonths(4);
                    dues = "Due Date of Payment : \n" + date.ToString("MMMM") + " 15" + "-" + dateEndPayment.ToString("MMMM") + "- ₱" + payments;
                    break;
                case "Quarterly":
                    duess = "Due Date of Payment : \n";
                    for (int i = 0; i < 3; i++)
                    {
                        date = date.AddMonths(3);
                        duess += date.ToString("MMMM") + " 15 " + date.ToString("yyyy") + " | ₱" + payments + "\n";
                    }
                    dues = duess;
                    break;

                case "Monthly":
                    duess = "Dute Date of Payment : \n";
                    for (int i = 0; i < 9; i++)
                    {
                        date = date.AddMonths(1);
                        duess += date.ToString("MMMM") + ", 15 " + date.ToString("yyyy") + " |  ₱" + payments + "\n";
                    }
                    dues = duess;
                    break;
            }

            return dues;
        }
    }
}
