using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Task2
{
    class Program
    {
        public static void Level(int l)
        {
            for (int i = 0; i < l; i++)
            {
                Console.Write("  ");
            }
        }
        public static void FILE(DirectoryInfo dir, int level)
        {
            foreach(FileInfo f in dir.GetFiles())
            {
                Level(level);
                Console.WriteLine(f.Name);
            }
            foreach(DirectoryInfo d in dir.GetDirectories())
            {
                Level(level);
                Console.WriteLine(d.Name);
                FILE(d, level + 1);
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:/Users/Alisher/Desktop/c#/lab1");
            FILE(dir, 0);
        }
    }
}