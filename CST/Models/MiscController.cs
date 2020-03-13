using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Models
{
    class MiscController
    {
        crudFile cs = new crudFile();
        YearController yrcontroller = new YearController();
        int syid = 0;
        public MiscController()
        {
            syid = yrcontroller.getSchoolYearId();
        }

        public void addMisc(string details,double price,string grade)
        {
            string sql = String.Format(@"INSERT INTO misc_fee (details,price,grade_level,SY_ID) VALUES('{0}',{1},'{2}',{3})",
                                        details, price, grade, syid);

            cs.ExecuteQuery(sql);
        }

        public void fillDataGridMisc(ref DataGridView dg,string grade)
        {
            string sql = String.Format(@"SELECT details,price,grade_level FROM misc_fee WHERE SY_ID = {0} AND grade_level = '{1}'", syid,grade);

            cs.FillDataGrid(sql, ref dg);
        }

        public void fillDataGridAllMisc(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT details,price,grade_level FROM misc_fee WHERE SY_ID = {0} ", syid);

            cs.FillDataGrid(sql, ref dg);
        }
    }
}
