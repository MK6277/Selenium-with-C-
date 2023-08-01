using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitDemo2
{
    [TestFixture]
    public class NUnitDemo2
    {
        public int i = 0,j = 0;

        [OneTimeSetUp]
        public void oneTimeSetup()

        {
            
            i = ++i;
        }
        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("inside setup i is : ", +i);
            j= ++j;
            Console.WriteLine("inside setup j is : ", +j);
        }
        [Test]
        public void Test1() 
        {
            Console.WriteLine("Test1 method");
        }
        [Test]
        public void Test2()
        {
            Console.WriteLine("Test2 method");
        }

        [TearDown]
        public void Teardown()
        {
            Console.WriteLine("Inside taerdown, i is : ", +i);
            j = ++j;
            Console.WriteLine("Inside taerdown, j is : ", +j);
        }

        [OneTimeTearDown]

        public void OneTimeTearDown()
        {
            i = ++i;
        }
    }
}
