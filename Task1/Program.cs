using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Act(string s)
        {
            bool k = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[s.Length - 1 - i] != s[i])
                {
                    k = false;
                    break;
                }
            }
                if (k)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }


        


    
        static void Main(string[] args)
        {

            FileStream gid = new FileStream(@"C: \Users\Alisher\Desktop\all files\all\qqq.txt", FileMode.Open, FileAccess.Read);
            StreamReader gs = new StreamReader(gid);

            string s = gs.ReadLine();
            Act(s);
            gs.Close();
            gid.Close();
        
        }
    }
}
