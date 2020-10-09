using CST.Docs;
using CST.Models;
using CST.Models.Student;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST.Registrar
{
    public partial class reqattachment : Form
    {
        List<requirementmodel> listModel = new List<requirementmodel>();
        SchoolRequirementsController schoolRequirementsController = new SchoolRequirementsController();
        List<Image> listImage = new List<Image>();
        Dictionary<int, Image> dicImage = new Dictionary<int, Image>();
        crudFile cs = new crudFile();

        public reqattachment()
        {
            InitializeComponent();
            loadReq();
          
        }


        private void loadReq()
        {
            int[] reqIds = StudentModel.getReq_ids();
          
           foreach(int id in reqIds)
            {
                requirementmodel req = schoolRequirementsController.getRequirementModel(id);
                listModel.Add(req);
              
            }

            LoadListParams();
        }

        private void LoadListParams()
        {
            panelParam.Controls.Clear();

            foreach(requirementmodel req in listModel)
            {
                DocsAdding d = new DocsAdding();
                d.ReqId = req.id;
                d.ReqName = req.name;
                d.Dock = DockStyle.Top;
                panelParam.Controls.Add(d);
            }
        }

        private async void save()
        {
            string path = CreateDirectory.CreateDir(StudentModel.getSno() + "-" + StudentModel.getLn());
        
            foreach (DocsAdding d in panelParam.Controls)
            {
               
                dicImage.Add(d.ReqId, d.Image);
            }

            foreach(KeyValuePair<int,Image> kp in dicImage)
            {

                string datenow = DateTime.Now.ToString("yyyy--MM--dd");
                string timenow = DateTime.Now.ToString("HH--mm--ss--tt");
                string combine = datenow + "--" + timenow;
                string filename = combine + "--" + kp.Key + ".jpg";
                kp.Value.Save(path  + filename);

              await  saveDb(kp.Key, filename, path);

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            save();
            RegistrarForm frm = new RegistrarForm();
            frm.Show();
            StudentModel.clearAll();
            this.Close();
        }


        //databasesavingh


        private async Task saveDb(int reqid, string filename, string path)
        {
            string sql = String.Format(@"INSERT INTO attach_requirements (student_no,req_id,filename,path) 
                                        VALUES (@sno,@reqid,@filename,@path)");

            List<MySqlParameter> listparams = new List<MySqlParameter>();

            listparams.Add(new MySqlParameter("@sno", StudentModel.getSno()));

            listparams.Add(new MySqlParameter("@reqid", reqid));

            listparams.Add(new MySqlParameter("@filename", filename));

            listparams.Add(new MySqlParameter("@path", path));

           await cs.ExecuteAsync(sql, listparams);

        }

       //database saving
    }
}
