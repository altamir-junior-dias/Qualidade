using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Qualidade
{
    [Binding]
    public class Calculadora
    {
        [When(@"acessar a página da calculadora")]
        public void QuandoAcessarAPaginaDaCalculadora()
        {
            Eventos.Selenium.
                Navigate().
                GoToUrl("http://agendeseuhorario.somee.com/calculadora/");
        }

        [Then(@"o resultado deve ser (.*)")]
        public void EntaoOResultadoDeveSer(String resultado)
        {
            Assert.
                AreEqual(resultado, 
                    Eventos.Selenium.
                        FindElementByXPath("//*[@id=\"ctl01\"]/div[2]/div[2]/table/tbody/tr[1]/td[1]/input").
                        GetAttribute("value"));
        }

        [When(@"clicar no igual")]
        public void QuandoClicarNoIgual()
        {
            Eventos.Selenium.
                FindElementByXPath("//*[@id=\"ctl01\"]/div[2]/div[2]/table/tbody/tr[5]/td[4]/input").
                Click();
        }

        [When(@"clicar no numero (.*)")]
        public void QuandoClicarNoNumero(Char numero)
        {
            switch (numero)
            {
                case '1':
                    Eventos.Selenium.FindElementByXPath("//*[@id=\"ctl01\"]/div[2]/div[2]/table/tbody/tr[2]/td[1]/input").Click();
                    break;
                case '2':
                    Eventos.Selenium.FindElementByXPath("//*[@id=\"ctl01\"]/div[2]/div[2]/table/tbody/tr[2]/td[2]/input").Click();
                    break;
                case '3':
                    Eventos.Selenium.FindElementByXPath("//*[@id=\"ctl01\"]/div[2]/div[2]/table/tbody/tr[2]/td[3]/input").Click();
                    break;
                case '4':
                    Eventos.Selenium.FindElementByXPath("//*[@id=\"ctl01\"]/div[2]/div[2]/table/tbody/tr[3]/td[1]/input").Click();
                    break;
                case '5':
                    Eventos.Selenium.FindElementByXPath("//*[@id=\"ctl01\"]/div[2]/div[2]/table/tbody/tr[3]/td[2]/input").Click();
                    break;
                case '6':
                    Eventos.Selenium.FindElementByXPath("//*[@id=\"ctl01\"]/div[2]/div[2]/table/tbody/tr[3]/td[3]/input").Click();
                    break;
                case '7':
                    Eventos.Selenium.FindElementByXPath("//*[@id=\"ctl01\"]/div[2]/div[2]/table/tbody/tr[4]/td[1]/input").Click();
                    break;
                case '8':
                    Eventos.Selenium.FindElementByXPath("//*[@id=\"ctl01\"]/div[2]/div[2]/table/tbody/tr[4]/td[2]/input").Click();
                    break;
                case '9':
                    Eventos.Selenium.FindElementByXPath("//*[@id=\"ctl01\"]/div[2]/div[2]/table/tbody/tr[4]/td[3]/input").Click();
                    break;
                case '0':
                    Eventos.Selenium.FindElementByXPath("//*[@id=\"ctl01\"]/div[2]/div[2]/table/tbody/tr[5]/td[2]/input").Click();
                    break;
            }
        }

        [Given(@"o número (.*)")]
        public void DadoONumero(String numero)
        {
            foreach (var num in numero)
            {
                QuandoClicarNoNumero(num);
            }
        }

        [Given(@"a operação (.*)")]
        public void DadoAOperacao(String operacao)
        {
            switch (operacao)
            {
                case "+":
                    Eventos.Selenium.FindElementByXPath("//*[@id=\"ctl01\"]/div[2]/div[2]/table/tbody/tr[2]/td[4]/input").Click();
                    break;

                case "-":
                    Eventos.Selenium.FindElementByXPath("//*[@id=\"ctl01\"]/div[2]/div[2]/table/tbody/tr[3]/td[4]/input").Click();
                    break;

                case "*":
                    Eventos.Selenium.FindElementByXPath("//*[@id=\"ctl01\"]/div[2]/div[2]/table/tbody/tr[4]/td[4]/input").Click();
                    break;

                case "/":
                    Eventos.Selenium.FindElementByXPath("//*[@id=\"ctl01\"]/div[2]/div[2]/table/tbody/tr[3]/td[4]/input").Click();
                    break;
            }
        }

    }
}
