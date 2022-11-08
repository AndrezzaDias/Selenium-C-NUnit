using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestProject1
{
    public class Begin
    {
        public IWebDriver driver;


        [SetUp]
        public void InicioTests()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://buscacepinter.correios.com.br");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }


        [TearDown]
        public void FimDoTeste()
        {

        }
    }
}