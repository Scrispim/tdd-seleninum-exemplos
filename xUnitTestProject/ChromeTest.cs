using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace xUnitTestProject
{
    public class ChromeTest : IDisposable
    {
        private IWebDriver _driver;
        private string urlIndex = "http://localhost/CalculadoraWeb/Calculadora/Index";

        public ChromeTest()
        {
            _driver = new ChromeDriver();
        }
        
        [Fact]
        public void Soma()
        {
            RealizaOperacao(p_PrimeiroValor: 2, p_SegundoValor: 2, p_Opcao: "Addition", p_Resultado: 4);
        }

        [Fact]
        public void Subtracao()
        {
            RealizaOperacao(p_PrimeiroValor: 3, p_SegundoValor: 2, p_Opcao: "Subtraction", p_Resultado: 1);
        }

        [Fact]
        public void Multiplicacao()
        {
            RealizaOperacao(p_PrimeiroValor: 3, p_SegundoValor: 2, p_Opcao: "Multiplication", p_Resultado: 6);
        }

        [Fact]
        public void Divisao()
        {
            RealizaOperacao(p_PrimeiroValor: 10, p_SegundoValor: 2, p_Opcao: "Division", p_Resultado: 5);
        }

        protected void RealizaOperacao(int p_PrimeiroValor, int p_SegundoValor, string p_Opcao, int p_Resultado)
        {
            _driver.Navigate().GoToUrl(urlIndex);
            IWebElement txtPrimeiroNumero = _driver.FindElement(By.Name(Constantes.Label.PRIMEIRO_NUMERO));
            txtPrimeiroNumero.SendKeys(p_PrimeiroValor.ToString());

            IWebElement txtSegundoNumero = _driver.FindElement(By.Name(Constantes.Label.SEGUNDOO_NUMERO));
            txtSegundoNumero.SendKeys(p_SegundoValor.ToString());

            List<IWebElement> options = _driver.FindElements(By.TagName(Constantes.Label.OPCAO)).ToList();
            foreach (IWebElement element in options)
            {
                if (element.Text.Equals(p_Opcao))
                {
                    element.Click();
                    break;
                }
            }

            IWebElement btnCalcular = _driver.FindElement(By.Name(Constantes.Label.BTN_CALCULAR));
            btnCalcular.Click();

            Assert.Equal(p_Resultado.ToString() , _driver.FindElement(By.Name(Constantes.Label.RESULTADO)).GetAttribute(Constantes.Label.VALUE).ToString());
        }

        public void Dispose()
        {
            if(_driver != null)
            {
                _driver.Close();
            }
        }
    }
}
