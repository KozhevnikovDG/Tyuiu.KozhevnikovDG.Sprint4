using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KozhevnikovDG.Sprint4.Task3.V28.Lib
{
    public class DataService : ISprint4Task3V28
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;
            
            int minElement = array[0, 3];

            for (int j = 0; j < colums; j++)
            {
                for(int i = 0; i < rows; i++)
                {
                    if(array[i,3] < minElement)
                    {
                        minElement = array[i, 3];
                    }
                }
            }
            return minElement;
        }
    }
}
