using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint1.Task2.V28.Lib;

namespace Tyuiu.KasenovAE.Sprint1.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckConvertCelsiusToKelvinValid()
        {
            DataService ds = new DataService();
            var res = ds.ConvertCelsiusToKelvin(0);
            Assert.AreEqual(273, res);
        }
    }
}
