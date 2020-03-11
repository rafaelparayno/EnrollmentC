using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST.Models
{
    class StudentBalance
    {
        crudFile cs = new crudFile();
        YearController yr = new YearController();
        int syid = 0;
        public StudentBalance()
        {
            syid = yr.getSchoolYearId();

        }

        public void addBalance(string sno,double balance,string mod,double need)
        {
            string sql = String.Format(@"INSERT INTO `student_balance`(`sno`, `balance`, `modeofpayment`, `need_to_pay`, `SY_id`) VALUES ('{0}',{1},'{2}',{3},{4})",
                                        sno, balance, mod, need, syid);
        }
    }
}
