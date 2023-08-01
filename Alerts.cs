using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Alerts
{

    [TestFixture]
       internal class Alerts
    {
        IWebDriver driver;
        string driverpath = "D:\\Apps\\chromedriver.chromedriver.exe";

        [SetUp]
        public void steup()
        {
           driver = new ChromeDriver(driverpath);
            driver.Navigate().GoToUrl("https://chercher.tech/practice/practice-pop-ups-selenium-webdriver");
            driver.Manage().Window.Maximize();  
        }
        [Test]
        public void alert()
        {
            driver.FindElement(By.Name("alert")).Click();
            string t = driver.SwitchTo().Alert().Text;
            Console.WriteLine(t);
            driver.SwitchTo().Alert().Accept();
            Console.WriteLine("Popup accepted");
        }
        [Test]
        public void confirmation()
        {
            driver.FindElement(By.Name("confirmation")).Click();
            string t1 = driver.SwitchTo().Alert().Text;
            Console.WriteLine(t1);
            driver.SwitchTo().Alert().Dismiss();
            Console.WriteLine("confirmation dismissed");
        }
        [Test]
        public void prompt()
        {
            driver.FindElement(By.Name("prompt")).Click();
            string t2 = driver.SwitchTo().Alert().Text;
            Console.WriteLine(t2);
            driver.SwitchTo().Alert().SendKeys("prompt");
            driver.SwitchTo().Alert().Accept();

        }
        [TearDown]
        public void end()
        {
            driver.Quit();
        }
    }
}
