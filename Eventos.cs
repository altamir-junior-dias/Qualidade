using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using System;

namespace Qualidade
{
    [Binding]
    public static class Eventos
    {
        public static FirefoxDriver Selenium;

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Selenium = new FirefoxDriver();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Selenium.Quit();
        }

        [BeforeScenario("cenarioSimples")]
        public static void BeforeScenarioCenarioSimples()
        {
            Console.WriteLine("cenario1");
        }

        [BeforeScenario("variasAdicoes")]
        public static void BeforeScenarioVariasAdicoes()
        {
            Console.WriteLine("outro cenario");
        }
    }
}
