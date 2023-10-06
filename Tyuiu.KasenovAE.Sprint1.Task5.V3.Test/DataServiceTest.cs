using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint1.Task5.V3.Lib;

namespace Tyuiu.KasenovAE.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(130985);
            Assert.AreEqual(9, res);
        }
    }
}
