using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectFramework1.Attri13
{
    [TestClass]
    [TestCategory("priority")]
    public class Priorityexecution
    {
        [TestMethod]
        [Priority(2)]
        public void priormethod()
        {
            Console.WriteLine("priority is given as 2");
        }
        [TestMethod]
        [Priority(3)]
        public void priormethod2()
        {
            Console.WriteLine("priority is 3");
        }

        [TestMethod]
        [Priority(1)]
        public void priormethod3()
        {
            Console.WriteLine("priority is 1");
        }
        [TestMethod]
        [Priority(2)]
        
        public void priormethod0()
        {
            Console.WriteLine("priority is 2");
        }

        [TestMethod]
        [Priority(0)]
        public void priormethod1() 
        {
            Console.WriteLine("priority is 0");

        }
    }
}
