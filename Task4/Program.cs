using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        
        public static void Place(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);//dir
            string pat = directory.Parent.FullName;// previous dir
            using (FileStream fs = File.Create(path + "/KBTU.txt"))
            {

            }
            File.Copy(path + "/KBTU.txt", pat + "/KBTU.txt");/*копируем существующий файл в новый*/

        }



        static void Main(string[] args)
        {
            string path = "C:/Users/Alisher/Desktop/all files/Video/Alisher"; // dir
            Place(path);
            File.Delete(path + "/KBTU.txt");//delete original file

        }
    }
}
