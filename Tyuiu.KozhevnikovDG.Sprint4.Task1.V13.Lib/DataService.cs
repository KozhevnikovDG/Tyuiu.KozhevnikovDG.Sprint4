using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KozhevnikovDG.Sprint4.Task1.V13.Lib
{
    public class DataService : ISprint4Task1V13
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            for(int i = 0; i < array.Length - 1; i++)
            {
                if(array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}
