using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SauceDemoTest.BasePage;
using SauceDemoTest.Pages;
using System;

namespace SauceDemoTest.Tests
{
    [TestClass]
    public class HomeTest : BaseClass
    {
        HomePage homepage;
        LoginPage loginpage;

        [TestMethod]
        public void PriceCheck()
        {
            homepage = new HomePage(driver);
            loginpage = new LoginPage(driver);
            loginpage.EnterUserName("standard_user");
            loginpage.EnterPassword("secret_sauce");
            loginpage.ClickLogin();
            String productPrice = homepage.GetJacketPrice();
            homepage.OpenJacketLink();
            String desPrice = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div/div[2]/div[3]")).Text;
            Console.WriteLine("DesPrice : "+desPrice +"ProdPrice : " +productPrice);
            Assert.AreEqual(desPrice, productPrice);
        }
    }
}
