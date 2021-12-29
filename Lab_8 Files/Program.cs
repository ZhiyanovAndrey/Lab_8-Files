using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_8_Files
{
    //8.1.Выберите любую папку на своем компьютере, имеющую вложенные директории.
    //Выведите на консоль ее содержимое и содержимое всех подкаталогов.
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\QTTabBar";
            Print(path,0);
            Console.ReadKey();
        }
        static void Print(string path, int level) //второй аргумент метода устанавливает отступ
        {
            string[] dirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            if (dirs.Count() > 0 || files.Count() > 0)
            {
                string offset = new string('\t', level);//добавляет отступ
                foreach (string s in files)
                {
                    Console.WriteLine(offset + s);
                }
                foreach (string s in dirs)
                {
                    Console.WriteLine(offset + s);
                    Print(s, level + 1); /*Рекурсия взыов метода внутри самого себя с другим аргументом с путем к 
                                          * следующей папке и добавляет уровень */
                                                     
                }
            }


        }
    }
}
