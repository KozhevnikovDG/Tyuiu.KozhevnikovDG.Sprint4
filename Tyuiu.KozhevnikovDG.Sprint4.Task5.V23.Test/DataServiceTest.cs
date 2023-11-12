using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KozhevnikovDG.Sprint4.Task5.V23.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint4.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                DataService ds = new DataService();
                int[,] mas = new int[5, 5] { { 1, 2, 3, 4, 5 },
                                         { -1, 3, 3, 2, 1 },
                                         { -1, 2, 2, 3, 4 },
                                         { 6, 4, 1, -3, 2 },
                                         { 3, 3, 5, 5, 1 } };
                int[,] res = ds.Calculate(mas);
                int[,] wait = new int[5, 5] { { 1, 2, 3, 4, 5 },
                                         { 0, 3, 3, 2, 1 },
                                         { 0, 2, 2, 3, 4 },
                                         { 6, 4, 1, 0, 2 },
                                         { 3, 3, 5, 5, 1 } };
                CollectionAssert.AreEqual(wait, res);
            }
        }
    }
}
