using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorovenkoGV.Sprint4.Task2.V26.Lib;


namespace Tyuiu.GorovenkoGV.Sprint4.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numsArray = { 2, 5, 3, 8, 2, 6, 2, 5, 5, 7, 4 };
            int res = ds.Calculate(numsArray);
            int numsWaitArray = 2625;
            Assert.AreEqual(numsWaitArray, res);
        }
    }
}
