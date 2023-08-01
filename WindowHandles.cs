using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WindowHandles
{
    [TestFixture]
    internal class WindowHandles
    {
        IWebDriver driver;
        string driverpath = "D:\\Apps\\chromedriver.chromedriver.exe";

        [SetUp]
        public void steup()
        {
            driver = new ChromeDriver(driverpath);
            driver.Navigate().GoToUrl("https://demo.automationtesting.in/Windows.html");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void WindowHandlesTest()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'Open New Tabbed')]")).Click();
            driver.FindElement(By.XPath("//a/button[@class=\"btn btn-info\"]")).Click();

            //Getting window handles
            IReadOnlyCollection<string> newtab = driver.WindowHandles;
            foreach(string tab in newtab)
            {
                driver.SwitchTo().Window(tab);
                Console.WriteLine(driver.Title);
            }

            
        }
        [TearDown]
        public void end()
        {
            driver.Close();
        }

    }
}
