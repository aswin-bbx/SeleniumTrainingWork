using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTest.Pages
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver) {
            this.driver = driver;
        }

        public static readonly By username = By.Id("user-name");
        public static readonly By password = By.Id("password");
        public static readonly By loginbtn = By.Id("login-button");

        public void EnterUserName(String user)
        {
            driver.FindElement(username).SendKeys(user);
        }
        public void EnterPassword(String pass)
        {
            driver.FindElement(password).SendKeys(pass);
        }

        public void ClickLogin() 
        { 
            driver.FindElement(loginbtn).Click();
        }

        public String GetTitle()
        {
            return driver.Title;
        }

    }
}
