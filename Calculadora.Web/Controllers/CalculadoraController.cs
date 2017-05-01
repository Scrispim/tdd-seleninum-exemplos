using Calculadora.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BdCalc = BakanasDigitais.Calculadora.Util;

namespace Calculadora.Web.Controllers
{
    public class CalculadoraController : Controller
    {
        // GET: Calculadora
        [HttpGet]
        public ActionResult Index(CalculadoraModel model = null)
        {
            if(model != null)
            {
                BdCalc.Calculadora calc = new BdCalc.Calculadora();

                switch (model.Operacao)
                {
                    case 0:
                        model.Resultado = calc.Somar(model.PrimeiroNumero, model.SegundoNumero);
                        break;
                    case 1:
                        model.Resultado = calc.Subtrair(model.PrimeiroNumero, model.SegundoNumero);
                        break;
                    case 2:
                        model.Resultado = calc.Mutiplicar(model.PrimeiroNumero, model.SegundoNumero);
                        break;
                    case 3:
                        model.Resultado = calc.Dividir(model.PrimeiroNumero, model.SegundoNumero);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                model = new CalculadoraModel();
            }
            return View(model);
        }
    }
}