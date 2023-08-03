using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UnitTestProjectFramework1
{
    [TestClass]
    [TestCategory("Initialize")]
    public class Initialization
    {
        [TestInitialize]
        public void Testinitialize()
        {
            Console.WriteLine("this is test initialize");
        }

        [TestMethod]
        public void Method()
        {
            Console.WriteLine("method");
        }

        [TestCleanup]
        public void Testcleanup()
        {
            Console.WriteLine("this is test cleanup");
        }



        [TestInitialize]
        public void Testinitialize1()
        {
            Console.WriteLine("this is test initialize1");
        }
        [TestMethod]
        public void Method1()
        {
            Console.WriteLine("method 1");
        }

        [TestCleanup]
        public void Testcleanup1()
        {
            Console.WriteLine("this is test cleanup1");
        }
    }
}
