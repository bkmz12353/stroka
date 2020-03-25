using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Пример_решения_задачи_по_теме_Строки
{
    class Program
    {
        


        static void Main(string[] args)
        {
            Console.WriteLine("Для ввода данных из файла введите 1, для ручного ввода введите 0!");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i == 1)
            {
                reader();
            }
            else if (i == 0)
            {
                
                reader1();
            }
            else
            {
                Console.WriteLine("Неверный ввод!");
                Main(args);
            }
            
        }

        static void reader1()
        {
            string stroka;
            Console.WriteLine("Введите строку:");
            stroka = Console.ReadLine().Trim();
            while (stroka.Contains("  "))
            {
                stroka = stroka.Replace("  ", " ");
            }
            Console.WriteLine(stroka);
            Console.ReadLine();
        }
        static void reader()
        {
             StreamReader fileIn = new StreamReader("1.in");
         StreamWriter fileout = new StreamWriter("2.out");
            string text;
            string[] predlojenie;
            text = fileIn.ReadToEnd();
            fileIn.Close();
            predlojenie = text.Trim().Split('\r');
            for (int i = 0; i < predlojenie.Length; i++)
            {
                predlojenie[i] = predlojenie[i].Trim();
                while (predlojenie[i].Contains("  "))
                {
                    predlojenie[i] = predlojenie[i].Replace("  ", " ");
                }
                fileout.WriteLine(predlojenie[i]);
            }
            Console.ReadLine();
            fileout.Close();
        }
        
    } 
}



      