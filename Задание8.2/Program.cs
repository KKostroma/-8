using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs/Log.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                int[] array = new int[10];
                Random random = new Random();
                int S = 0;
                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(array.Length);
                    S += array[i];
                    sw.Write("{0} ", array[i]);
                }
                Console.WriteLine(S);
            }
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}
