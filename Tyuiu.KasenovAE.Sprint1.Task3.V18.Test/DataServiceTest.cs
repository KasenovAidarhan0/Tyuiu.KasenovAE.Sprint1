using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint1.Task3.V18.Lib;

namespace Tyuiu.KasenovAE.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckHowManySquaresValid()
        {
            DataService ds = new DataService();
            var res = ds.HowManySquares(4, 6, 2);
            Assert.AreEqual(6, res);
        }
    }
}
