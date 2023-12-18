using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome; 
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace YourProjectNamespace
{
    [Binding]
    public class LoginSteps
    {
        private IWebDriver driver;
        private LoginPage loginPage;

        public LoginSteps()
        {
            // Ініціалізуємо драйвер у конструкторі
            driver = new ChromeDriver(); // Ви можете вибрати інший драйвер за потребою
            loginPage = new LoginPage(driver);
        }

        [Given(@"I am on the swag website")]
        public void GivenIAmOnTheSwagWebsite()
        {
            loginPage.OpenLoginPage("https://www.saucedemo.com"); // Замініть URL на реальний URL вашого веб-сайту
        }

        [Then(@"I'm logging in")]
        public void WhenLoggingIn()
        {
            loginPage.EnterUsernameAndPassword();
        }

        [When(@"I'm adding to cart backpack")]
        public void AddingBackpackToCart()
        {
            loginPage.AddItemToCart("add-to-cart-sauce-labs-backpack");
        }

        [Then(@"I should see backpack in a cart")]
        public void checkBackpackInCart()
        {
            string item = loginPage.CheckItemInCart(0);
            Assert.AreEqual(item, "Sauce Labs Backpack", "No backpack in a cart");
        }

        [When(@"I'm adding to T-Shirt")]
        public void AddingTShirtToCart()
        {
            loginPage.AddItemToCart("add-to-cart-sauce-labs-bolt-t-shirt");
        }

        [Then(@"I should see T-Shirt in a cart")]
        public void checkTShirtInCart()
        {
            string item = loginPage.CheckItemInCart(1);
            Assert.AreEqual(item, "Sauce Labs Bolt T-Shirt", "No T-Shirt in a cart");
        }

        [Then(@"I should close Chrome")]
        public void CloseChrome()
        {
            loginPage.CloseDriver();
        }
    }
}
