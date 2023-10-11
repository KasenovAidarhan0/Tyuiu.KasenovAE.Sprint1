using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint1.Task7.V8.Lib;

namespace Tyuiu.KasenovAE.Sprint1.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(6, 2);
            Assert.AreEqual(res, 8.827);
        }
    }
}
