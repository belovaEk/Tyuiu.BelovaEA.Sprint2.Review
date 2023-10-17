using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint2.TaskReview.V9.Lib;

namespace Tyuiu.BelovaEA.Sprint2.TaskReview.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            Assert.AreEqual(false, ds.CheckDotInShadedArea(x,y));
        }
    }
}
