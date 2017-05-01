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
            _driver.Navigate().GoToUrl(urlIndex);
            IWebElement txtPrimeiroNumero = _driver.FindElement(By.Name("PrimeiroNumero"));
            txtPrimeiroNumero.SendKeys("2");

            IWebElement txtSegundoNumero = _driver.FindElement(By.Name("SegundoNumero"));
            txtSegundoNumero.SendKeys("2");

            List<IWebElement> options = _driver.FindElements(By.Name("option")).ToList();
            foreach (IWebElement element in options)
            {
                if (element.Text.Equals("Adição"))
                {
                    element.Click();
                    break;
                }
            }

            IWebElement btnCalcular = _driver.FindElement(By.Name("btnCalcular"));
            btnCalcular.Click();

            Assert.Equal("4", _driver.FindElement(By.Name("Resultado")).GetAttribute("value").ToString());
        }

        [Fact]
        public void Subtracao()
        {
            _driver.Navigate().GoToUrl(urlIndex);
            IWebElement txtPrimeiroNumero = _driver.FindElement(By.Name("PrimeiroNumero"));
            txtPrimeiroNumero.SendKeys("3");

            IWebElement txtSegundoNumero = _driver.FindElement(By.Name("SegundoNumero"));
            txtSegundoNumero.SendKeys("2");

            List<IWebElement> options = _driver.FindElements(By.Name("option")).ToList();
            foreach (IWebElement element in options)
            {
                if (element.Text.Equals("Subtração"))
                {
                    element.Click();
                    break;
                }
            }

            IWebElement btnCalcular = _driver.FindElement(By.Name("btnCalcular"));
            btnCalcular.Click();

            Assert.Equal("1", _driver.FindElement(By.Name("Resultado")).GetAttribute("value").ToString());
        }

        [Fact]
        public void Multiplicacao()
        {
            _driver.Navigate().GoToUrl(urlIndex);
            IWebElement txtPrimeiroNumero = _driver.FindElement(By.Name("PrimeiroNumero"));
            txtPrimeiroNumero.SendKeys("3");

            IWebElement txtSegundoNumero = _driver.FindElement(By.Name("SegundoNumero"));
            txtSegundoNumero.SendKeys("2");

            List<IWebElement> options = _driver.FindElements(By.Name("option")).ToList();
            foreach (IWebElement element in options)
            {
                if (element.Text.Equals("Multiplicação"))
                {
                    element.Click();
                    break;
                }
            }

            IWebElement btnCalcular = _driver.FindElement(By.Name("btnCalcular"));
            btnCalcular.Click();

            Assert.Equal("6", _driver.FindElement(By.Name("Resultado")).GetAttribute("value").ToString());
        }

        [Fact]
        public void Divisao()
        {
            _driver.Navigate().GoToUrl(urlIndex);
            IWebElement txtPrimeiroNumero = _driver.FindElement(By.Name("PrimeiroNumero"));
            txtPrimeiroNumero.SendKeys("10");

            IWebElement txtSegundoNumero = _driver.FindElement(By.Name("SegundoNumero"));
            txtSegundoNumero.SendKeys("2");

            List<IWebElement> options = _driver.FindElements(By.Name("option")).ToList();
            foreach (IWebElement element in options)
            {
                if (element.Text.Equals("Divisão"))
                {
                    element.Click();
                    break;
                }
            }

            IWebElement btnCalcular = _driver.FindElement(By.Name("btnCalcular"));
            btnCalcular.Click();

            Assert.Equal("5", _driver.FindElement(By.Name("Resultado")).GetAttribute("value").ToString());
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
