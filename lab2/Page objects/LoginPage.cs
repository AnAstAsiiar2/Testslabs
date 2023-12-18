using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Linq.Expressions;
using System.Threading;

public class LoginPage
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
    }

    // Метод для відкриття сторінки в браузері
    public void OpenLoginPage(string url)
    {
        driver.Navigate().GoToUrl(url);
    }

    // Метод для вибору опції "Login as Bank Manager"
    public void EnterUsernameAndPassword()
    {
        // Знайдіть елемент кнопки "Bank Manager Login" за допомогою селектора і натисніть на неї
        IWebElement usernameInput = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("user-name")));
        usernameInput.SendKeys("performance_glitch_user");
        IWebElement passwordInput = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("password")));
        passwordInput.SendKeys("secret_sauce");
        IWebElement loginInput = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("login-button")));
        loginInput.Click();
    }

    public void AddItemToCart(string id)
    {
        Thread.Sleep(1000);
        IWebElement button = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id(id)));
        button.Click();
        Thread.Sleep(2000);
    }

    public string CheckItemInCart(int index)
    {
        IWebElement cartbutton = wait.Until(ExpectedConditions.ElementToBeClickable(By.ClassName("shopping_cart_container")));
        cartbutton.Click();
        IWebElement itemElement = driver.FindElements(By.ClassName("inventory_item_name"))[index];
        string item = itemElement.Text;
        IWebElement continueShopping = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("continue-shopping")));
        continueShopping.Click();
        Thread.Sleep(1000);
        return item;
    }

    public void CloseDriver()
    {
        driver.Quit();
    }

}
