using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KozhevnikovDG.Sprint4.Task2.V2.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint4.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] array = { 8, 1, 5, 4, 2, 1, 2, 7, 6, 1, 3 };
            int res = ds.Calculate(array);
            int arrayWait = 105;
            Assert.AreEqual(arrayWait, res);
        }
    }
}
