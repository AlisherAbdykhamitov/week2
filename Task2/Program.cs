using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static bool IsPrime(int x)
        {
            if (x == 1)
            {
                return false;
            }

            if (x == 2)
            {
                return true;
            }
            bool k = true;

            for (int i = 2; i < x; ++i)
            {
                if (x % i == 0)
                {
                    k = false;
                    break;
                }
            }
            return k;
        }


        static bool SN(string s)
        {
            return IsPrime(int.Parse(s));
        }


        static void Main(string[] args)
        {
            List<string> A = new List<string>();/* создает пустую строку */

            FileStream fs = new FileStream(@"C:\Users\Alisher\Desktop\all files\all\qqq.txt", FileMode.Open, FileAccess.Read);/* читаю  документ*/
            StreamReader sr = new StreamReader(fs);/*считываю символы из кого либо документа */

            string line = sr.ReadLine();/*создаем строку , в которую перемещаем все объекты файла*/
            string[] s = line.Split(' ');/* создаем массив стринга , где будет элементы стринга Line , они буду разделены между собою ' '*/


            foreach (var x in s)
            {
                if (SN(x))/* закидываем каждый х в  bool SN функцию */
                {
                    A.Add(x);/* Если оно возвращает return true мы добавляем элементы в пустой стринг*/
                }
            }
            sr.Close();
            fs.Close();

            FileStream fs2 = new FileStream(@"C:\Users\Alisher\Desktop\all files\all\zhan.txt", FileMode.Open, FileAccess.Write);
            StreamWriter gid = new StreamWriter(fs2);

            foreach (var x in A)

            {
                gid.Write(x + ' ');
                Console.Write(x + ' ');
            }
            gid.Close();
            fs2.Close();
        }


    }
}





