using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KozyrevRA.Sprint4.Task2.V8.Lib;
namespace Tyuiu.KozyrevRA.Sprint4.Task2.V8
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
            Console.WriteLine("* Тема:  Одномерные массивы (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Козырев Роман Артёмович | СМАРТБ-25-1                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов заполненный         *");
            Console.WriteLine("* статическими случайными значениями в диапазоне от 2 до 7                *");
            Console.WriteLine("* Подсчитать сумму нечетных элементов массива.                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите длину массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] mas = new int[len];

            for (int i = 0; i < len; i++)
            {
                mas[i] = rnd.Next(2,7);
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(mas));
            Console.ReadKey();
        }
    }
}