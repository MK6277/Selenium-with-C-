using NUnit.Framework;

namespace Sel_Basic_CSharp_Demo

{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("setup");
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("TEst1");
        }
        public void Test2()
        {
            Console.WriteLine("TEst2");
        }

        [TearDown]

         public void TearDown() 
        {
            Console.WriteLine("teardown");
         }
    }
}
