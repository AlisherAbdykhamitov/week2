using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)

        {

            string filename = "File.txt";
            string path1 = @"C:\Users\Alisher\Desktop\all files";
            string path2 = @"C:\Users\Alisher\Desktop\Examples";
            string sourcefile = Path.Combine(path1, filename);
            string destfile = Path.Combine(path2, filename); // path2 + "//" + filename
            FileStream fs = File.Create(sourcefile); // создаем
            fs.Close(); // закрываем , потому что мы его используем
            File.Copy(sourcefile, destfile, true); // копируем
            File.Delete(sourcefile); // удаляем

        }

    }

}
