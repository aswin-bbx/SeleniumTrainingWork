﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTest.Pages
{
    public class HomePage
    {
        public IWebDriver driver;

        public static readonly By jacketlink = By.Id("item_5_img_link");
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public static readonly By logo = By.ClassName("app_logo");
        public String GetTitle()
        {
            return driver.Title;
        }

        public bool isLogoDisplayed()
        {
         return driver.FindElement(logo).Displayed;
        }

        public void OpenJacketLink()
        {
            driver.FindElement(jacketlink).Click();
        }

        public String GetJacketPrice()
        {
             return driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div/div/div[4]/div[2]/div[2]/div")).Text;
        }
    }
}
