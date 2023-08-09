using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static UnitTestProjectFramework1.AssemblyTest;

namespace UnitTestProjectFramework1
{
    [TestClass]
    public class AssemblyTest
    {
        public static TestContext testContext;
            public TestContext TestContext
        {
            get { return testContext; }
            set { testContext = value; }
        }

        [AssemblyInitialize]
        public static void AssemblyIni(TestContext _testContext)
        {
            testContext= _testContext;
            //MessageBox.Show("this is Assemblyinitialzer");
        }

      /*  [TestMethod]
        [TestCategory("TC"),Owner("veena")]
        [Priority(1)]
        public void Browserrun()
        {
            if (TestContext.Properties["Browser"].Equals("Chrome"))
            {
                IWebDriver driver=new ChromeDriver();
            }
            else
            {
                Assert.Fail("invalid browser");

            }
            TestContext.WriteLine(TestContext.TestName);
            TestContext.WriteLine(TestContext.Properties["Browser"].ToString());
        }

        [AssemblyCleanup]
        public static void Assemblycleanup()
        {
            MessageBox.Show("this is Assemblycleanup");
        }*/
    }
}

