using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.HodakovaNA.Sprint3.Task2.V10.Lib;

namespace Tyuiu.HodakovaNA.Sprint3.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 1; //t
            int startValue = 1;
            int stopValue = 13;
            double MultiplySeries = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 7.5;

            Assert.AreEqual(wait, MultiplySeries);
        }
    }
}
