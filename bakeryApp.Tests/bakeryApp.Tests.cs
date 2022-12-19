using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace bakeryApp.Tests
{
    [TestClass]
    public class bakeryCalcTests
    {
        [TestMethod]
        public void loavesCalc_CostCalculation_int()
        {
            int expected = 15;
            Assert.AreEqual(expected, Bread.loavesCalc(4));
        }
        [TestMethod]
        public void pastriesCost_CostCalculation_int()
        {
            int expected = 7;
            Assert.AreEqual(expected, Pastry.pastriesCost(4));
        }
    }
}