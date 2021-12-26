using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задача_8_работа_с_файловой_системой
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = "C:/Users/MaxGaev/Desktop/програмирование C";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Random abc = new Random();
            StreamWriter S = new StreamWriter(path);
            for (int i = 0; i < 10; i++)
            {
                S.WriteLine(abc.Next(10));
            }
            S.Close();
            StreamReader sr = new StreamReader(path);
            int sum = 0;
            string str;
            while ((str = sr.ReadLine()) != null)
            {
                sum += Convert.ToInt32(str);
            }
            Console.WriteLine("Сумма чисел в файле равна {0}", sum);
            Console.ReadKey();

        }
    }
}
