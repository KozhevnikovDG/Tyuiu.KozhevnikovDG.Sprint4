using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KozhevnikovDG.Sprint4.Task1.V13.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint4.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 8, 1, 5, 4, 2, 1, 2, 7, 6, 1 };
            int res = ds.Calculate(array);
            int arrayWait = 22;
            Assert.AreEqual(arrayWait, res);
        }
    }
}
