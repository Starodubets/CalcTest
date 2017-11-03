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
        [TestMethod()]
        public void funct_calcTest12()
        {
            int res = Form1.Calculator.funct_calc(5, 2, '-');
            Assert.AreEqual(3, res); ;
        }
        [TestMethod()]
        public void funct_calcTest13()
        {
            int res = Form1.Calculator.funct_calc(3, 2, '*');
            Assert.AreEqual(6, res); ;
        }
        [TestMethod()]
        public void funct_calcTest14()
        {
            int res = Form1.Calculator.funct_calc(6, 3, '/');
            Assert.AreEqual(2, res); ;
        }
    }
}