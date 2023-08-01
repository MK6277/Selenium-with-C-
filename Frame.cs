using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Frame
{
    [TestFixture]
    internal class Frame
    {
        WebDriver driver;
        string driverpath = "D:\\Apps\\chromedriver.chromedriver.exe";

        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver(driverpath);
            driver.Url = "https://demo.automationtesting.in/Frames.html";
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testframe()
        {
            driver.SwitchTo().Frame(1);
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("kkkk");
        }
        [TearDown] public void tearDown()
        {
            driver.Close();
        }
    }
}
