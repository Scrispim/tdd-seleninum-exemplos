using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using BdCalc = BakanasDigitais.Calculadora.Util;

namespace xUnitTestProject
{
    public class MultiplicacaoTest : IDisposable
    {
        private BdCalc.Calculadora _calc;
        public MultiplicacaoTest()
        {
            _calc = new BdCalc.Calculadora(2);
        }
        
        [Fact]
        public void Multiplicacao()
        {
            Assert.Equal(9, _calc.Mutiplicar(3, 3));
        }

        [Fact]
        public void MultiplicarPrimeioArgumentoAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => 
            {
                _calc.Mutiplicar(1, 3);
            });
        }

        [Fact]
        public void MultiplicarSegundoArgumentoAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc.Mutiplicar(3, 1);
            });
        }

        [Fact]
        public void MultiplicarTodosArgumentoAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc.Mutiplicar(1, 1);
            });
        }
        
        public void Dispose()
        {
            _calc = null;
        }
    }
}
