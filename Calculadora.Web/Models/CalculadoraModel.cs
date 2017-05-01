using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calculadora.Web.Models
{
    public class CalculadoraModel
    {
        public int PrimeiroNumero { get; set; }
        public int SegundoNumero { get; set; }
        public int Operacao { get; set; }
        public int Resultado { get; set; }
    }
}