using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint1.Task4.V3.Lib;

namespace Tyuiu.KasenovAE.Sprint1.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(6, 2);
            Assert.AreEqual(res, 2.222);
        }
    }
}
