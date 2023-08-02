using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectFramework1.Attri13.priorityTestscripts
{
    [TestClass]
    [TestCategory("Priority execution")]
    public class Priority
    {
        [TestMethod]
        [Priority(0)]
        public void Testmethod1()
        {
            Console.WriteLine("this is testmethod 1");
        }

        [TestMethod]
        [Priority(0)]
        public void Testmethod2() 
        {
            Console.WriteLine("this is testmethod 2");
        }

        [TestMethod]
        [Priority(1)]
        public void Testmethod3()
        {
            Console.WriteLine("this is test method 3");
        }

        [TestMethod]
        [Priority(0)]   
        public void Testmethod4()
        {
            Console.WriteLine("this is test method 4");
        }
    }
}
