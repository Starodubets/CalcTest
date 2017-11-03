using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace WindowsFormsCalc2
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void funct_calcTest11()
        {
            int res = Form1.Calculator.funct_calc(1, 2, '+');
            Assert.AreEqual(3, res); ;
        }
    }
}