using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KozhevnikovDG.Sprint4.Task0.V27.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint4.Task0.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Кожевников Д. Г. | ИИПБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Кожевников Данил Георгиевич | ИИПБ-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать произведение   *");
            Console.WriteLine("* нечетных элементов массива. {7 ,4 ,3 ,2 ,1 ,5 ,9 ,8 ,7 ,4}              *");

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            int res = ds.GetMultOddArrEl(numsArray);
           
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
