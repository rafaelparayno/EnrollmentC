using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST.Models.Student
{
    class StudentModel
    {
        //Detailes
        private static string sno;
        private static string fn;
        private static string ln;
        private static string mn;
        private static string gender;
        private static int age = 0;
        private static string birthdate;
        private static string pob;
        private static string cn;
        private static string religion;
        private static string nationality;
        private static string addressGlob;

        //setter Details
        public static void setFn(string firstname)
        {
            fn = firstname;
        }

        public static void setLn(string lastname)
        {
            ln = lastname;
        }

        public static void setSno(string studno)
        {
            sno = studno;
        }

        public static void setMn(string middlename)
        {
            mn = middlename;
        }

        public static void setGender(string gen)
        {
            gender = gen;
        }

        public static void setAge(int studAge)
        {
            age = studAge;
        }

        public static void setBd(string bd)
        {
            birthdate = bd;
        }

        public static void setPlaceofbirth(string place)
        {
            pob = place;
        }

        public static void setCn(string contact)
        {
            cn = contact;
        }

        public static void setRel(string rel)
        {
            religion = rel;
        }

        public static void setNat(string nat)
        {
            nationality = nat;
        }

        public static void setAddress(string address)
        {
            addressGlob = address;
        }

        //getter Details

        public static string getSno()
        {
            return sno;
        }

        public static string getFn()
        {
            return fn;
        }

        public static string getMn()
        {
            return mn;
        }
        public static string getLn()
        {
            return ln;
        }

        public static string getGen()
        {
            return gender;
        }

        public static int getAge()
        {
            return age;
        }

        public static string getbirthdate()
        {
            return birthdate;
        }

        public static string getPob()
        {
            return pob;
        }

       

        public static string getCn()
        {
            return cn;
        }

        public static string getRel()
        {
            return religion;

        }

        public static string getNat()
        {
            return nationality;
        }

        public static string getAddress()
        {
            return addressGlob;
        }


        //requirements
        private static int[] pass_req_ids;
        private static string type_of_student;
       





        //Setter
        public static void setReq_ids(int[] req_ids)
        {
            pass_req_ids = req_ids;
        }
        public static void setTypeOfStudents(string typeStud)
        {
            type_of_student = typeStud;
        }

        public static int[] getReq_ids()
        {
            return pass_req_ids;
        }

        public static string getTypeStud()
        {
            return type_of_student;
        }


        //geter


        //Family Details

        private static string father_name;
        private static string father_no;
        private static string father_occu;
        private static string father_comp_name;
        private static string father_Ctel_no;
        private static string father_office_address;

        private static string mother_name;
        private static string mother_no;
        private static string mother_occu;
        private static string mother_comp_name;
        private static string mother_Ctel_no;
        private static string mother_office_address;

        private static string guardian_name;
        private static string guardian_add;
        private static string guardian_rel;
        private static string guardian_no;

        private static string parent_status;


        //father
        public static void setFather_name(string name)
        {
            father_name = name;
        }


        public static void setFather_no(string name)
        {
            father_no = name;
        }



        public static void setFather_occu(string name)
        {
            father_occu = name;
        }


        public static void setFather_compname(string name)
        {
            father_comp_name = name;
        }


        public static void setFather_Ctelno(string name)
        {
            father_Ctel_no = name;
        }



        public static void setFather_officeAdd(string name)
        {
            father_office_address = name;
        }

        public static void setParent_status(string name)
        {
            parent_status = name;
        }

        public static string getParent_status()
        {
            return parent_status;
        }



        //mother
        public static void setMother_name(string name)
        {
            mother_name = name;
        } 

        public static void setMother_no(string name)
        {
            mother_no = name;
        }

        public static void setMother_occu(string name)
        {
            mother_occu = name;
        }

        public static void setMother_compname(string name)
        {
            mother_comp_name = name;
        }

        public static void setMother_Ctelno(string name)
        {
            mother_Ctel_no = name;
        }

        public static void setMother_officeAdd(string name)
        {
            mother_office_address = name;
        }



        public static void setGuardian_name(string name)
        {
            guardian_name = name;
        }
        public static void setGuardian_add(string name)
        {
            guardian_add = name;
        }
        public static void setGuardian_rel(string name)
        {
            guardian_rel = name;
        }
        public static void setGuardian_no(string name)
        {
            guardian_no = name;
        }




        //getter for famdetails
        public static string getFather_name()
        {
            return father_name;
        }

        public static string getFather_no()
        {
            return father_no;
        }


        public static string getFather_occu()
        {
            return father_occu;
        }

        public static string getFather_comp()
        {
            return father_comp_name;
        }

        public static string getFather_Ctel()
        {
            return father_Ctel_no;
        }

        public static string getFather_CAdd()
        {
            return father_office_address;
        }

        public static string getMother_name()
        {
            return mother_name;
        }

        public static string getMother_no()
        {
            return mother_no;
        }


        public static string getMother_occu()
        {
            return mother_occu;
        }

        public static string getMother_comp()
        {
            return mother_comp_name;
        }

        public static string getMother_Ctel()
        {
            return mother_Ctel_no;
        }

        public static string getMother_CAdd()
        {
            return mother_office_address;
        }



        public static string getGuardian_name()
        {
            return guardian_name;
        }
        public static string getGuardian_add()
        {
            return guardian_add;
        }
        public static string getGuardian_rel()
        {
            return guardian_rel;
        }
        public static string getGuardian_no()
        {
            return guardian_no;
        }

        public static void clearAll()
        {
            sno = "";
            fn = "";
            ln = "";
            mn = "";
            gender = "";
            age = 0;
            birthdate = "";
            pob = "";
            cn = "";
            religion = "";
            nationality = "";
            addressGlob = "";
            father_name = "";
            father_no = "";
            father_occu = "";
            father_comp_name = "";
            father_Ctel_no = "";
            father_office_address = "";

            mother_name = "";
            mother_no = "";
            mother_occu = "";
            mother_comp_name = "";
            mother_Ctel_no= "";
            mother_office_address = "";

            guardian_name = "";
            guardian_add = "";
            guardian_rel = "";
            guardian_no = "";
            parent_status = "";
    }

    }
}
