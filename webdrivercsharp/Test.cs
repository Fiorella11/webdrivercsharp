using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace webdrivercsharp
{
    public class Test
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Start test");
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1");

            IWebElement user = driver.FindElement(By.Id("user-name"));
            user.SendKeys("standard_user");

            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("secret_sauce");

            IWebElement btnLogin = driver.FindElement(By.Id("login-button"));
            btnLogin.Click();

            driver.Close();
            driver.Quit();
            Console.WriteLine("Finish test");
        }
    }
}