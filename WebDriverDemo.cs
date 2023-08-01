using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriverDemo
{
    [TestFixture]
    internal class WebDriverDemo
    {
        [Test]
        public void Driver()
        {
            IWebDriver driver;
            string driverPath = "D:\\Apps\\chromedriver.chromedriver.exe";
            driver = new ChromeDriver(driverPath);
            driver.Navigate().GoToUrl("https://www.google.com/");
            string title = driver.Title;
            Console.WriteLine(title);
            driver.Quit();
        }
        
    }
}
