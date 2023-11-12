using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KozhevnikovDG.Sprint4.Task7.V9.Lib;
    
namespace Tyuiu.KozhevnikovDG.Sprint4.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int rows = 3;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "864299753";
            DataService ds = new DataService();
            int res = ds.Calculate(rows,columns,str);
            int wait = 4;
            Assert.AreEqual(wait, res);
            
            
        }
    }
}
