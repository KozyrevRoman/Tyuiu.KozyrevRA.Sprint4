using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KozyrevRA.Sprint4.Task6.V23.Lib;
namespace Tyuiu.KozyrevRA.Sprint4.Task6.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Козырев Р. А. | СМАРТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:  Двумерные массивы. (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Козырев Роман Артёмович | СМАРТБ-25-1                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Дан строковый массив данных [Microsoft, Google, Apple, Amazon, Facebook,*");
            Console.WriteLine("* с Tesla, Netflix] используя класс Array подсчитайте количество          *");
            Console.WriteLine("* элементов, длина которых равна 6.                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string[] strings = { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };

            for (int i = 0; i < strings.Length; i++)
            {
                Console.Write(strings[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(strings));
            Console.ReadKey();
        }
    }
}