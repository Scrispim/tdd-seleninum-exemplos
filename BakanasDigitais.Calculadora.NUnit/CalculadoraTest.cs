using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BdCalc = BakanasDigitais.Calculadora.Util;

namespace BakanasDigitais.Calculadora.NUnit
{
    


    [TestFixture]
    class CalculadoraTest
    {
        private BdCalc.Calculadora _calc;

        [TestFixtureSetUp]
        public void SetUp()
        {
            _calc = new BdCalc.Calculadora();
        }

        [Test]
        public void Soma()
        {
            Assert.AreEqual(4, _calc.Somar(2,2));
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            _calc = null;
        }

        [Test]
        [Ignore("Teste ainda não implementado")]
        public void Multimplicar()
        {

        }
        
    }
}
