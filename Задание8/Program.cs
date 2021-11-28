using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo study = new DirectoryInfo("C:/Game");
            foreach (DirectoryInfo file in study.GetDirectories())
            {
                Console.WriteLine("Название : {0}", file.Name);
            }
            Console.ReadLine();
        }
    }
}
