using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProjectFramework1.Attributes
{
    [TestClass]
    [TestCategory("Attributes")]
    public class Timeoutandowner
    {
        [TestMethod,TestCategory("TimeOut"),Owner("veena")]
        [Timeout(1000)]
        public void Timeoutattr() 
        {
           Thread.Sleep(1000);
        }
    }
}
