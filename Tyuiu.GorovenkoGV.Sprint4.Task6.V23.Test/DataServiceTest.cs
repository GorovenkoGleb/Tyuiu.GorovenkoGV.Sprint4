using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GorovenkoGV.Sprint4.Task6.V23.Lib;


namespace Tyuiu.GorovenkoGV.Sprint4.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var comp = new string[] { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };
            int res = ds.Calculate(comp);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
