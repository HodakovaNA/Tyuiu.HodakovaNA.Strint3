using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.HodakovaNA.Sprint3.Task0.V9.Lib;

namespace Tyuiu.HodakovaNA.Sprint3.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Sanchi()
        {
            DataService ds = new DataService();
            double value = 0.5;
            int startValue = 1;
            int stopValue = 15;
            double SumSeries = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 0.430;
            Assert.AreEqual(wait, SumSeries);
        }
    }
}
