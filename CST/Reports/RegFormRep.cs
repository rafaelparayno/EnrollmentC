using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CST.Models;

namespace CST.Reports
{
    public partial class RegFormRep : Form
    {
        StudentsDetailsController DetailsController = new StudentsDetailsController();
        StudFamDetailsController famDetailsController = new StudFamDetailsController();
        StudHistDetailsController studHistDetailsController = new StudHistDetailsController();


        string[] details;
        string[] famdetails;
        string[] historydetails;
        //Details
        string sno = "";
        string firstname = "";
        string lastname = "";
        string middlename = "";
        string lvlApplying = "";
        string gender = "";
        string age = "";
        string dob = "";
        string pob = "";
        string nat = "";
        string rel = "";
       
        string cno = "";
        string add = "";
        //Details

        //famDetails
        string fn = "";
        string mn = "";
        string fo = "";
        string mo = "";
        string mno = "";
        string fno = "";
        string fcomp = "";
        string mcomp = "";
        string fcompno = "";
        string mcompno = "";
        string fcompadd = "";
        string mcompadd = "";
        string gname = "";
        string gadd = "";
        string gno = "";
        //famdetails

        //history
        string pName = "";
        string pAdd = "";
        string pGlvl = "";
        string pylvl = "";

        string isvaccine = "";
        string vacineDetails = "";

        //history 

        public RegFormRep(string sno)
        {
            InitializeComponent();
            this.sno = sno;
            details = DetailsController.searchAllDetails2(sno);
            firstname = details[1];
            lastname = details[2];
            middlename = details[3];
            gender = details[4];
            age = details[5];
            dob = details[6];
            pob = details[7];
            cno = details[8];
            nat = details[9];
            rel = details[10];
            add = details[11];
            lvlApplying = details[12];
            famdetails =  famDetailsController.getAllFamDetails(sno);

            fn = famdetails[0];
            fno = famdetails[1];
            fo = famdetails[2];
            fcomp = famdetails[3];
            fcompno = famdetails[4];
            fcompadd = famdetails[5];

            mn = famdetails[6];
            mno = famdetails[7];
            mo = famdetails[8];
            mcomp = famdetails[9];
            mcompno = famdetails[10];
            mcompadd = famdetails[11];

            gname = famdetails[12];
            gadd = famdetails[13];
            gno = famdetails[15];

            historydetails = studHistDetailsController.getHistStudent(sno);
            pName = historydetails[0];
            pAdd = historydetails[1];
            pGlvl = historydetails[2];
            pylvl = historydetails[3];
            isvaccine = historydetails[4];
            vacineDetails = historydetails[5];


        }

        public RegFormRep(string sno,string glvl)
        {
            InitializeComponent();
            this.sno = sno;
            details = DetailsController.searchAllDetails2(sno);
            firstname = details[1];
            lastname = details[2];
            middlename = details[3];
            gender = details[4];
            age = details[5];
            dob = details[6];
            pob = details[7];
            cno = details[8];
            nat = details[9];
            rel = details[10];
            add = details[11];
            lvlApplying = glvl;
            famdetails = famDetailsController.getAllFamDetails(sno);

            fn = famdetails[0];
            fno = famdetails[1];
            fo = famdetails[2];
            fcomp = famdetails[3];
            fcompno = famdetails[4];
            fcompadd = famdetails[5];

            mn = famdetails[6];
            mno = famdetails[7];
            mo = famdetails[8];
            mcomp = famdetails[9];
            mcompno = famdetails[10];
            mcompadd = famdetails[11];

            gname = famdetails[12];
            gadd = famdetails[13];
            gno = famdetails[15];

            historydetails = studHistDetailsController.getHistStudent(sno);
            pName = historydetails[0];
            pAdd = historydetails[1];
            pGlvl = historydetails[2];
            pylvl = historydetails[3];
            isvaccine = historydetails[4];
            vacineDetails = historydetails[5];


        }

        private void RegFormRep_Load(object sender, EventArgs e)
        {
            CrystalReport1 cos = new CrystalReport1();
            cos.SetParameterValue("sno", sno);
            cos.SetParameterValue("FirstName", firstname);
            cos.SetParameterValue("LastName", lastname);
            cos.SetParameterValue("MiddleName", middlename);
            cos.SetParameterValue("levelApply", lvlApplying);
            cos.SetParameterValue("Gender", gender);
            cos.SetParameterValue("Age", age);
            cos.SetParameterValue("Dob", dob);
            cos.SetParameterValue("Pob", pob);
            cos.SetParameterValue("Nat", nat);
            cos.SetParameterValue("Rel", rel);
            cos.SetParameterValue("TelNo", "");
            cos.SetParameterValue("Cno", cno);
            cos.SetParameterValue("Address", add);


            cos.SetParameterValue("fatName", fn);
            cos.SetParameterValue("MotName", mn);
            cos.SetParameterValue("mOccu", mo);
            cos.SetParameterValue("fOccu", fo);
            cos.SetParameterValue("fNum", fno);
            cos.SetParameterValue("mNum", mno);
            cos.SetParameterValue("fComp", fcomp);
            cos.SetParameterValue("mComp", mcomp);
            cos.SetParameterValue("mCompNo", mcompno);
            cos.SetParameterValue("fCompNo", fcompno);
            cos.SetParameterValue("fCompAd", fcompadd);
            cos.SetParameterValue("mCompAd", mcompadd);
            cos.SetParameterValue("Guard", gname);
            cos.SetParameterValue("GuardAdd", gadd);
            cos.SetParameterValue("GuardNo", gno);
            cos.SetParameterValue("pSname", pName);
            cos.SetParameterValue("pSAd", pAdd);
            cos.SetParameterValue("pGlvl", pGlvl);
            cos.SetParameterValue("pLvl", pylvl);

            crystalReportViewer1.ReportSource = cos;
        }

        private void init()
        {
            
        }
    }
}
