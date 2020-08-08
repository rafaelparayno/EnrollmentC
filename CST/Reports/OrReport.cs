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

namespace CST.Reports
{
    public partial class OrReport : Form
    {
        double tot = 0;
        string numWord = "";
        string name = "";
        string tuition = "";
        string misc = "";
        string total = "";
        double disc = 0;
        double reservation = 0;
        int orno = 0;
        string part = "";
        StudentsDetailsController studentsDetails = new StudentsDetailsController();
        OrController ornocontroller = new OrController();

        public OrReport(double total,string sno,
                        string tui,string misc,
                        string totalPhp,int orno,
                        double disc,double reservation,
                        string fromPart )
        {
            InitializeComponent();
            tot = total;
            tuition = tui;
            this.misc = misc;
            this.total = totalPhp;
            this.orno = orno;
            this.disc = disc;
            this.reservation = reservation;
            name = studentsDetails.searchAllDetails(sno)[0] + " " + studentsDetails.searchAllDetails(sno)[1];
            orno = ornocontroller.getRecentOr();
            this.part = fromPart;
        }

        private void OrReport_Load(object sender, EventArgs e)
        {
            DateTime aDate = DateTime.Now;
            int _;

            if(int.TryParse(tot + "",out _))
            {
                numWord = NumberToWords(int.Parse(tot + ""));
            }
            else
            {
                double newTot = Math.Floor(tot);
                int decplaces = (int)(((decimal)tot % 1) * 100);
              
                numWord = NumberToWords(int.Parse(newTot + ""));
                numWord = decplaces > 0 ? numWord + getDecPlacesWord(decplaces) : numWord;
            }


          
            or rep = new or();

            rep.SetParameterValue("orNoParam", orno.ToString());
            rep.SetParameterValue("wordNumberparam", numWord);
            rep.SetParameterValue("totalParam", tot);
            rep.SetParameterValue("studentName", name);
            rep.SetParameterValue("DateNow", aDate.ToString("MM/dd/yyyy"));
            rep.SetParameterValue("cashierName", UserLog.getFullName());

            if (misc == "" || misc == null && part == "enrollment")
            {
                rep.SetParameterValue("part1", "Tuition Payment:");
                rep.SetParameterValue("part2", "");
            }
            else
            {
                rep.SetParameterValue("part1", "Tuition");
                rep.SetParameterValue("part2", "Misc");

            }
            
            if(part == "balance")
            {
                rep.SetParameterValue("part1", "Balance Payment:");
                rep.SetParameterValue("part2", "");
            }

            if(part == "reservation")
            {
                rep.SetParameterValue("part1", "Reservation Payment:");
                rep.SetParameterValue("part2", "");
            }

            if (reservation > 0 )
            {
                rep.SetParameterValue("part4", "Reservation");
                string reserveString = "PHP " + reservation;
                rep.SetParameterValue("part4value", reserveString);
            }

            if(disc > 0 )
            {
                rep.SetParameterValue("part3", "Discount");
                string discString = "PHP " + disc;
                rep.SetParameterValue("part3value", discString);

            }
            
            rep.SetParameterValue("partvalue1", tuition);
            rep.SetParameterValue("partvalue2", misc);
       
           
            rep.SetParameterValue("totalpart", total);
            crystalReportViewer1.ReportSource = rep;                    
        }

        public  string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += " ";

                string[] unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
               string[] tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }

        private string getDecPlacesWord(int number)
        {
            string word = " and ";

            string[] tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            word += tensMap[number / 10];
            return word + " Cents";
        }
    }
}
