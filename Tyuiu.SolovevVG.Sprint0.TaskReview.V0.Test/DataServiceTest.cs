using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SolovevVG.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.SolovevVG.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int x = 2;
            int y = 3;
            int z = 1;
            int res = DataService.Calc(x, y, z);
            Assert.AreEqual(30, res);
        }
    }
}
