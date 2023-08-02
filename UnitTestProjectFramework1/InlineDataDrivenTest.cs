using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectFramework1
{
    public class InlineDataDrivenTest
    {
           [TestMethod]
            [TestCategory("DDT")]
            [DataTestMethod]
            [DataRow("admin", "manager")]
            [DataRow("admin12", "manager")]
            [DataRow("admin123", "manager")]
            public void Methods1(string username, string password)
            {
                Console.WriteLine(username, password);
                Console.WriteLine(username, password);
            }

            public static void Main(string[] args)
            {
                InlineDataDrivenTest.Main(args);
            }
        
    }
}
