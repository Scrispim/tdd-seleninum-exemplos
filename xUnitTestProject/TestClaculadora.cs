using System;
using BdCalc = BakanasDigitais.Calculadora.Util;
using Xunit;

namespace xUnitTestProject
{
    
    public class TestCalculadora :IDisposable
    {
        private BdCalc.Calculadora _calc;

        public TestCalculadora()
        {
            _calc = new BdCalc.Calculadora(3);
        }

        [Fact]
        public void Soma()
        {
            Assert.Equal(6, _calc.Somar(3,3));
        }

        [Fact]
        public void SomaComlimite()
        {
            Assert.Equal(6, _calc.Somar(3,3));
        }

        [Fact]
        public void TestSomaForaLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => {

                Assert.Equal(7, _calc.Somar(2, 2));

            });
            
        }
        
        public void Dispose()
        {
            _calc = null;
        }
    }
}
