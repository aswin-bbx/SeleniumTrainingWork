using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTest.BasePage
{
    public class BaseClass
    {
        public IWebDriver driver;

        [TestInitialize]
        public void Init()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void Cleanup()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
