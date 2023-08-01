using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Pratctice01
{
    [TestFixture]
    internal class Pratctice01
    {
        [Test]
        public void PT1()
        {
            IWebDriver driver;
            string driverPath = "D:\\Apps\\chromedriver.chromedriver.exe";
            driver = new ChromeDriver(driverPath);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com/");
            string Ps = driver.PageSource;
            Console.WriteLine(Ps);
            Console.ReadLine();
            driver.Quit();
        }
    }
}
