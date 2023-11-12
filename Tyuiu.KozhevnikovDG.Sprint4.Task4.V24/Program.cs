using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KozhevnikovDG.Sprint4.Task4.V24.Lib;
namespace Tyuiu.KozhevnikovDG.Sprint4.Task4.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Кожевников Д. Г. | ИИПБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Кожевников Данил Георгиевич | ИИПБ-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,заполненный         *");
            Console.WriteLine("* значениями значениями с клавиатуры от 5 до 9. Заменить четные элементы  *");
            Console.WriteLine("* массива на 1                                                            *");

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите кол-во строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите кол-во столбцов в массиве ");
            int colums = Convert.ToInt32(Console.ReadLine());

            int[,] matrx = new int[rows, colums];

            Console.WriteLine("***************************************************************************");

            for ( int i = 0; i < rows; i++)
            {
                for( int j = 0; j < colums;j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    matrx[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            Console.WriteLine("\nМассив:");
            for ( int i = 0; i < rows; i++)
            {
                for( int j = 0; j < colums;j++)
                {
                    Console.Write($"{matrx[i,j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Итоговый массив: ");
            int[,] res = ds.Calculate(matrx);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{matrx[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
