using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Models
{
    class StudFamDetailsController
    {
        crudFile cs = new crudFile();
        YearController yearController = new YearController();
        private int syid = 0;
        public StudFamDetailsController()
        {
            syid = yearController.getSchoolYearId();
        }

        public void addFamDetails(string sno,string[] arrFamDetails)
        {
            string sql = String.Format(@"INSERT INTO `student_family_details`(`sno`, `father_name`, `father_no`, `father_occu`, `father_comp_name`, `father_Ctel_no`, `father_office_address`, `mother_name`, `mother_no`, `mother_occu`, `mother_comp_name`, `mother_Ctel_no`, `mother_office_add`, `guardian_name`, `guardian_add`, `guardian_relation`, `guardian_no`, `parent_status`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}')",
                                        sno,arrFamDetails[0], arrFamDetails[1], arrFamDetails[2], arrFamDetails[3], arrFamDetails[4], arrFamDetails[5], arrFamDetails[6], arrFamDetails[7], arrFamDetails[8],
                                        arrFamDetails[9], arrFamDetails[10], arrFamDetails[11], arrFamDetails[12], arrFamDetails[13], arrFamDetails[14], arrFamDetails[15], arrFamDetails[16]);
            cs.ExecuteQuery(sql);

        }

        public void updateFamDetails(string[] arrFamDetails,string sno)
        {
            string sql = String.Format(@"UPDATE `student_family_details` SET `father_name`='{0}',`father_no`='{1}',`father_occu`='{2}',`father_comp_name`='{3}',`father_Ctel_no`='{4}',`father_office_address`='{5}',`mother_name`='{6}',`mother_no`='{7}',`mother_occu`='{8}',`mother_comp_name`='{9}',`mother_Ctel_no`='{10}',`mother_office_add`='{11}',`guardian_name`='{12}',`guardian_add`='{13}',`guardian_relation`='{14}',`guardian_no`='{15}',`parent_status`='{16}' WHERE sno = '{17}'",
                                        arrFamDetails[0], arrFamDetails[1], arrFamDetails[2], arrFamDetails[3], arrFamDetails[4], arrFamDetails[5], arrFamDetails[6], arrFamDetails[7],
                                        arrFamDetails[8], arrFamDetails[9], arrFamDetails[10], arrFamDetails[11], arrFamDetails[12], arrFamDetails[13], arrFamDetails[14], arrFamDetails[15],
                                        arrFamDetails[16], sno);
       
            cs.ExecuteQuery(sql);
        }

        public void filldataGridFam(ref DataGridView dg)
        {
            string sql = String.Format(@"SELECT `sno`, `father_name`, `father_no`, `father_occu`, `father_comp_name`, `father_Ctel_no`, `father_office_address`, `mother_name`, `mother_no`, `mother_occu`, `mother_comp_name`, `mother_Ctel_no`, `mother_office_add`, `guardian_name`, `guardian_add`, `guardian_relation`, `guardian_no`, `parent_status` FROM `student_family_details` WHERE sno in (SELECT sno FROM student_detail WHERE isEnrolled ='enrolled' )");

            cs.FillDataGrid(sql,ref dg);
        }
    }
}
