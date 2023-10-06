using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint1.Task6.V14.Lib;

namespace Tyuiu.KasenovAE.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLowerCaseRusLettersValidTrue()
        {
            string TestString = "воамщвслмдаб";
            DataService ds1 = new DataService();
            var res = ds1.CheckLowerCaseRusLetters(TestString);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void CheckLowerCaseRusLettersValidFalse()
        {
            string TestString = "воамщвслghhd";
            DataService ds2 = new DataService();
            var res = ds2.CheckLowerCaseRusLetters(TestString);
            Assert.AreEqual(false, res);
        }
    }
}
