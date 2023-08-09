using OpenQA.Selenium;
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
        public static readonly By product = By.ClassName("inventory_item");
        public static readonly By AddtocartButton = By.XPath("//*[@id=\"add-to-cart-sauce-labs-backpack\"]");
        public static readonly By cartNumber = By.XPath("//*[@id=\"shopping_cart_container\"]/a/span");
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
        public int GetCount()
        {
            return driver.FindElements(product).Count();
        }

        public String GetTShirtPrice()
        {
            return driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div/div/div[3]/div[2]/div[2]/div")).Text;
        }

        public void ClickAddToCart()
        {
            driver.FindElement(AddtocartButton).Click();
        }

        public string getCartNumber() {
            return driver.FindElement(By.XPath("//*[@id=\"shopping_cart_container\"]/a/span")).Text;
        }
    }
}
