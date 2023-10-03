using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint1.Task1.V22.Lib;

namespace Tyuiu.KasenovAE.Sprint1.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(10, 10);
            Assert.AreEqual(0.15, res);
        }
    }
}
