using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Models
{
    class StudentReserveController
    {
        crudFile cs = new crudFile();
        YearController yrcontroller = new YearController();
        int syid = 0;

        public StudentReserveController()
        {
            syid = yrcontroller.getSchoolYearId();
        }

        public void addReservation(double payment,string sno)
        {
            if (!checkReserve(sno))
            {
                string sql = String.Format(@"INSERT INTO `student_reservepay`( `sno`, `payment`, `syid`) VALUES ('{0}',{1},{2})",
                                            sno, payment, syid);

                cs.ExecuteQuery(sql);
                MessageBox.Show("Succesfully Added Reservation");
            }
            else
            {
                MessageBox.Show("Student Already has an reservation", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool checkReserve(string sno)
        {
            bool hasRow = false;
            string sql = String.Format(@"SELECT * FROM student_reservepay WHERE sno = '{0}'", sno);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            if (reader.HasRows)
            {
                hasRow = true;
            }
            cs.CloseConnection();
            return hasRow;
        }
    }
}
