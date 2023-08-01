using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace checkboxandraidobuttons
{
    [TestFixture]
    internal class checkboxandraidobuttons
    {
        IWebDriver driver;
        string driverpath = "D:\\Apps\\chromedriver.chromedriver.exe";
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(driverpath);
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testing()
        {
            //raido button

           // driver.FindElement(By.CssSelector("input[value='radio2']")).Click();
            driver.FindElements(By.Name("radioButton")).ElementAt(2).Click();

            // check box

            driver.FindElement(By.Id("checkBoxOption1")).Click();

            

        }
        /*[TearDown] 
        public void TearDown()
        {
            driver.Close();
        }*/
    }
}
