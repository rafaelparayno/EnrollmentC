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

        public void fillGrid(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT reservepay AS 'ID',student_reservepay.sno,CONCAT(student_detail.firstname,' ',student_detail.lastname) AS 'StudentName',payment 
                                        FROM `student_reservepay` LEFT JOIN student_detail ON student_reservepay.sno = student_detail.sno WHERE syid = {0}", syid);

            cs.FillDataGrid(sql, ref dg);
        }


        public void fillGridSearchSno(ref DataGridView dg,string sno)
        {
            string sql = String.Format(@"SELECT reservepay AS 'ID',student_reservepay.sno,CONCAT(student_detail.firstname,' ',student_detail.lastname) AS 'StudentName',payment 
                                        FROM `student_reservepay` LEFT JOIN student_detail ON student_reservepay.sno = student_detail.sno WHERE syid = {0} 
                                        AND student_reservepay.sno = '{1}'", syid,sno);

            cs.FillDataGrid(sql, ref dg);
        }
    

        private bool checkReserve(string sno)
        {
            bool hasRow = false;
            string sql = String.Format(@"SELECT * FROM student_reservepay WHERE sno = '{0}' AND syid = {1}", sno,syid);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            if (reader.HasRows)
            {
                hasRow = true;
            }
            cs.CloseConnection();
            return hasRow;
        }

        public double getReservationFee(string sno)
        {
            double reservationFee = 0;
          
            string sql = String.Format(@"SELECT * FROM student_reservepay WHERE sno = '{0}' AND syid = {1}", sno, syid);
            MySqlDataReader reader = null;
            cs.RetrieveRecords(sql, ref reader);

            while (reader.Read())
            {
                reservationFee = double.Parse(reader["payment"].ToString());
            }

            cs.CloseConnection();
            return reservationFee;
        }
    }
}
