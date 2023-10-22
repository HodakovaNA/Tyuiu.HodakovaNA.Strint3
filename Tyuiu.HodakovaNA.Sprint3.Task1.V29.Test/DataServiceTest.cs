using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.HodakovaNA.Sprint3.Task1.V29.Lib;

namespace Tyuiu.HodakovaNA.Sprint3.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 11;
            Assert.AreEqual(13051.340, ds.GetMultiplySeries(value, startValue, stopValue));
        }
    }
}
