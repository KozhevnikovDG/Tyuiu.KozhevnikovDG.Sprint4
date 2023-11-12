using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KozhevnikovDG.Sprint4.Task6.V8.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint4.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] mas = { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };
            string[] res = ds.Calculate(mas);
            string[] wait = { "Пицца", "Пельмени", "Омлет", "Салат", "Роллы" };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
