using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Practice2
{
    [TestFixture]
    internal class Waits
    {
       

        IWebDriver driver;
        string driverPath = "D:\\Apps\\chromedriver.chromedriver.exe";
        

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(driverPath);
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/locatorspractice/");
            driver.Manage().Window.Maximize();


        }

        [Test]
        public void loginAndLogout()
        {
            //Explicit wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));

            string title = driver.Title;
            Console.WriteLine(title);
            driver.FindElement(By.Id("inputUsername")).SendKeys("murali6277@gmail.com");
            driver.FindElement(By.Name("inputPassword")).SendKeys("rahulshettyacademy"); 
            driver.FindElement(By.ClassName("signInBtn")).Click();
            string title2 = driver.Title;
            Console.WriteLine(title2);
            IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//p[contains(text(),'successfully')]")));
            string msg = driver.FindElement(By.XPath("//p[contains(text(),'successfully')]")).Text;
            Assert.That( msg, Is.EqualTo("You are successfully logged in."));
            driver.FindElement(By.XPath("//button[contains(text(),'Log')]")).Click();

        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
