using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.HodakovaNA.Strint3.Task3.V14.Lib;

namespace Tyuiu.HodakovaNA.Strint3.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string value = "dgt ghedd bed";
            char replaceable = 'd';
            char replacement = '’';

            string res = ds.ReplaceCharInString(value, replaceable, replacement);
            string wait = "’gt ghe’’ be’";

            Assert.AreEqual(wait, res);
        }
    }
}
