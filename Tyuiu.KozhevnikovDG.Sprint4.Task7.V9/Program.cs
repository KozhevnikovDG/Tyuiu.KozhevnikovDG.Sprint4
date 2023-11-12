using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KozhevnikovDG.Sprint4.Task7.V9.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint4.Task7.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Кожевников Д.Г | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Кожевников Данил Георгиевич | ИИПб-23-3                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 864299753. Преобразуйте ее в матрицу  *");
            Console.WriteLine("* 3 на 3 и подсчитайте количество четных чисел.                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 3;
            int columns = 3;
            int[,] matrix = new int[3, 3];
            string str = "864299753";

            int index = 0;
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количесвто чётных элементов: " + ds.Calculate(rows, columns, str));

            Console.ReadKey();
        }
    }
}
