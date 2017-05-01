using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakanasDigitais.Calculadora.Util
{
    public class Calculadora
    {
        private int _limiteMinino;

        public Calculadora()
        {

        }
        public Calculadora(int p_LimiteMinimo)
        {
            _limiteMinino = p_LimiteMinimo;
        }

        public int Somar(int a, int b)
        {
            validaLimiteMinimo(a, b);

            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            validaLimiteMinimo(a, b);

            return a - b;
        }

        public int Mutiplicar(int a, int b)
        {
            validaLimiteMinimo(a, b);

            return a * b;
            //throw new NotImplementedException();
        }

        public int Dividir(int a, int b)
        {
            validaLimiteMinimo(a, b);

            if(b == 0)
            {
                throw new DivideByZeroException("Segundo argumento não pode ser zero");
            }

            return a / b;
            throw new NotImplementedException();
        }

        private  void validaLimiteMinimo(int a, int b)
        {
            if(a < _limiteMinino || b < _limiteMinino)
            {
                throw new ArgumentOutOfRangeException("O argumento está a abaixo do argumento mínimo.");
            }

        }

    }
}
