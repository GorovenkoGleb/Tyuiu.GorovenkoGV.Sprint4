using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GorovenkoGV.Sprint4.Task7.V24.Lib;

namespace Tyuiu.GorovenkoGV.Sprint4.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "651827384219648";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 1179648;
            Assert.AreEqual(wait, res);
        }
    }
}
