using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectFramework1.Objectrepo
{
    [TestClass]
    public class Baseclass
    {
        [TestMethod]
        public void Method()
        {

        }

        public IWebDriver driver;
        [TestInitialize]
        public void LoginToApp()
        {
            driver = new ChromeDriver();
            driver.Url = "https://demo.actitime.com/login.do";
        }
        [TestCleanup]
        public void Logout()
        {
            driver.Close();
            driver.Dispose();
            
        }
    }
}
