using Microsoft.VisualStudio.TestTools.UnitTesting;

using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using SauceDemoTest.BasePage;
using SauceDemoTest.Pages;
using System;
using System.Configuration;
using System.Xml.Linq;

namespace SauceDemoTest.Tests
{
    [TestClass]
    public class LoginTest : BaseClass
    {
        HomePage homepage;
        LoginPage loginpage;
        

        [TestMethod]
        public void CheckLoginSuccess()
        {
            
            homepage = new HomePage(driver);
            loginpage = new LoginPage(driver);
            String loginTitle = loginpage.GetTitle();
            loginpage.EnterUserName("standard_user");
            loginpage.EnterPassword("secret_sauce");
            loginpage.ClickLogin();
            Assert.IsTrue(homepage.isLogoDisplayed());
        }
    }
}
