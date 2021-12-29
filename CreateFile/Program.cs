using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreateFile
{
    /*8.2.Программно создайте текстовый файл и запишите в него 10 случайных чисел. 
     * Затем программно откройте созданный файл, рассчитайте сумму чисел в нем,
     * ответ выведите на консоль.*/
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Temp";
            string pathfile = @"C:\Temp\log.txt";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists(pathfile))
            {
                File.Create(pathfile);
            }
            Random random = new Random();
            int[] num = new int[10];
     //using - предпочтительный метод работы для StreamWriter и StreamReader
            using (StreamWriter sw = new StreamWriter(pathfile, true))//true-дописывать, false-перезапись по умолчанию
            {
                for (int i = 0; i < 10; i++) //ввод одномерного массива из случайных элементов
                {
                    num[i] = random.Next(0, 9);
                    sw.Write(num[i]);
                                    }
                sw.WriteLine();
            }
            using(StreamReader sr = new StreamReader(pathfile, true))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}
