using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectFramework1.ExtentReport
{
    [TestClass]
    public class Generatereport1
    {
        IWebDriver driver;
        [TestMethod]
        [DataTestMethod]
        [DataRow("myntra","https://www.myntra.com")]
        [DataRow("Ajio","https://www.ajio.com")]
        [DataRow("flipkart","https://www.flipkart.com")]
        [TestCategory("Reports")]
        public void Openbrowser(string website,string url,bool test)
        {
            driver.Navigate().GoToUrl(url);
            ITakesScreenshot takescreenshot = (ITakesScreenshot)driver;
            var Screenshot=takescreenshot.GetScreenshot();
            Screenshot.SaveAsFile("D:\\VisualStudioRepos\\UnitTestProjectFramework1\\UnitTestProjectFramework1\\Reports\\" + website + ".png");
        }
    }
}
