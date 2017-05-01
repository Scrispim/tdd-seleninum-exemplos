using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Bdcalc = BakanasDigitais.Calculadora.Util;

namespace xUnitTestProject
{
    public class DivisaoTest : IDisposable
    {
        private Bdcalc.Calculadora _calc;
        public DivisaoTest()
        {
            _calc = new Bdcalc.Calculadora(-1);
        }

        [Fact]
        public void Divisao()
        {
            Assert.Equal(1, _calc.Dividir(5, 5));
        }

        [Fact]
        public void DivisaoPrimeioArgumentoAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc.Dividir(-2, 10);
            });
        }

        [Fact]
        public void DivisaoSegundoArgumentoAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc.Dividir(6, -2);
            });
        }

        [Fact]
        public void DivisaoTodosArgumentoAbaixoLimite()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                _calc.Dividir(-2, -2);
            });
        }

        [Fact]
        public void DivisaoSegundoArgumentoPorZero()
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                _calc.Dividir(1, 0);
            });
        }

        public void Dispose()
        {
            _calc = null;
        }
    }
}
