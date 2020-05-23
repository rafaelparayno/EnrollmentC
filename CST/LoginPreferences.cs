using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CST
{
    class LoginPreferences
    {
        public static void CreateLoginPrefFile()
        {
            string dr = AppDomain.CurrentDomain.BaseDirectory+"Login.txt";
       
       
            bool exists = File.Exists(dr);

            if (!exists)
            {
               FileStream fs =  File.Create(dr);
                //  fs.Write();
                fs.Close();
            }
        }
    }
}
