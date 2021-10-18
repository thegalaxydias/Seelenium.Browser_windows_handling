using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Linq;

namespace Seelenium.Browser_windows_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");

            driver.Manage().Window.Maximize();

            driver.ExecuteJavaScript("window.open()");

            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Navigate().GoToUrl("https://itechcraft.com/");

            driver.SwitchTo().Window(driver.WindowHandles[0]);
            IWebElement logo = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/img"));

            bool logoPresent = logo.Displayed;


            if (logoPresent)
            {
                Console.WriteLine("Logo is present");
            }
            else
            {
                Console.WriteLine("Logo is absent");
            }
            

        }
    }
}
