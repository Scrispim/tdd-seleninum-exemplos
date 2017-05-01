using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BdCalc = BakanasDigitais.Calculadora.Util;

namespace BakanasDigitais.Calculadora.MSTest
{
    [TestClass]
    public class CalculadoraTests
    {
        private BdCalc.Calculadora _calc;

        [TestInitialize]
        public void SetUp()
        {
            _calc = new BdCalc.Calculadora();
        }

        [TestMethod]
        public void TestSomar()
        {
            Assert.AreEqual(4 ,_calc.Somar(2,2));
        }

        [TestMethod]
        public void TestSubtrair()
        {
            Assert.AreEqual(0, _calc.Subtrair(2, 2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSomarComExeption()
        {
            BdCalc.Calculadora _calc2 = new BdCalc.Calculadora(p_LimiteMinimo: 2);
            _calc2.Somar(1, 1);
        }

        [TestMethod]
        [Ignore]
        public void TestMultiplicar()
        {
        }

    }
}
