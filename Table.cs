using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Table
{
    [TestFixture]
    internal class Table
    {
        IWebDriver driver;
        string driverpath = "D:\\Apps\\chromedriver.chromedriver.exe";

        [SetUp]
        public void setup() 
        {
            driver = new ChromeDriver(driverpath);
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void test()
        {
            IWebElement table = driver.FindElement(By.Id("product"));
            IReadOnlyCollection<IWebElement> rows = table.FindElements(By.TagName("tr"));
            Console.WriteLine(rows.Count);
            for(int row_index = 1; row_index<rows.Count; row_index++)
            {
                IReadOnlyCollection<IWebElement> columns = rows.ElementAt(row_index).FindElements(By.TagName("td"));
                Console.WriteLine("No. of columns in row : " + row_index + " is " + columns.Count) ;
                for(int col_index =0; col_index<columns.Count; col_index++)
                {
                    Console.WriteLine("data is : " + columns.ElementAt(col_index).Text) ;
                }
            }
           
        }
    }
}
