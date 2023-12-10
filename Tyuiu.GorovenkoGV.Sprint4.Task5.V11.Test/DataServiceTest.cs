using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorovenkoGV.Sprint4.Task5.V11.Lib;

namespace Tyuiu.GorovenkoGV.Sprint4.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 9, 7, 4, 9, 7, },
                                          { 5, 2, 5, 7, 6, },
                                          { 8, 3, 3, 5, 7, },
                                          { 8, 4, 2, 4, 5, },
                                          { 8, 8, 9, 5, 6, } };
            int[,] res = ds.Calculate(matrix);
            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}
