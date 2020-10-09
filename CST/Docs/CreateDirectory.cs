using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST.Docs
{
    class CreateDirectory
    {
        public static string CreateDir(string dirName)
        {
            //CreateFileServer
            string newDir = String.Format(@"C:\{0}\", dirName);
            bool exists = File.Exists(newDir);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(newDir);
            }
            return newDir;
        }
    }
}
