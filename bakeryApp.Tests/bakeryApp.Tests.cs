using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace bakeryApp.Tests
{
    [TestClass]
    public class bakeryCalcTests
    {
        [TestMethod]
        public void loavesCalc_CostCalculation_int()
        {
            int expected = 10
            Assert.AreEqual(expected, Bread.loavesCalc(int 3));
        }
    }
}