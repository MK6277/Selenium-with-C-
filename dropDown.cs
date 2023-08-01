using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace dropDown
{
    [TestFixture]
    internal class dropDown
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
        public void DropDown1()
        {
            //dropdown

            //fetch dropdown web element

            IWebElement dropdown = driver.FindElement(By.Id("dropdown-class-example"));
            //using SelectElement class
            SelectElement DD = new SelectElement(dropdown);
            DD.SelectByIndex(1);
            IList<IWebElement> DD_options = DD.Options;

            foreach(WebElement Dropdown_option in DD_options)
            {
                Console.WriteLine(Dropdown_option.Text);
            }
            DD.SelectByValue("option3");
        }
    }
        
}
