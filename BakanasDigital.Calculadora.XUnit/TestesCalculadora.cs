using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using BdCalc = BakanasDigitais.Calculadora.Util;




namespace BakanasDigital.Calculadora.XUnit
{
    
    class TestesCalculadora
    {
        [Fact]
        public void Somar()
        {
            BdCalc.Calculadora _calc = new BdCalc.Calculadora();
            Assert.Equal(4, _calc.Somar(2,2));
        }
    }
}
