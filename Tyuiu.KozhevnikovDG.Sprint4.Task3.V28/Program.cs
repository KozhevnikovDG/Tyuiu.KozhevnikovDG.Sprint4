using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KozhevnikovDG.Sprint4.Task3.V28.Lib;
namespace Tyuiu.KozhevnikovDG.Sprint4.Task3.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Кожевников Д. Г. | ИИПБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Кожевников Данил Георгиевич | ИИПБ-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* ан двумерный целочисленный массив 5 на 5 элементов,заполненный          *");
            Console.WriteLine("*статическими значениями в диапазоне от 4 до 9.Найдите минимальный элемент*");
            Console.WriteLine("* в четвертом столбце                                                     *");

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] mtrx = new int[5, 5] { { 5, 4, 9, 8, 5, },
                                          { 4, 6, 6, 9, 9, },
                                          { 9, 8, 4, 8, 8, },
                                          { 6, 8, 6, 8, 9, },
                                          { 9, 4, 6, 6, 7, } };
            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;

            Console.WriteLine("Массив");
            for (int i = 0; i < rows;i++)
            {
                for(int j = 0; j < colums;j++)
                {
                    Console.WriteLine($"{mtrx[i,j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mtrx);

            Console.WriteLine("Минимальный элемент в четвертом столбце = " + res);
            Console.ReadKey();
        }
    }
}
