using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectFramework1.ExtentReport
{
    [TestClass]
    [TestCategory("Reports")]
    public class Extentreport
    {
        [TestMethod]
        
       public void Extentreports()
        {
            
            ExtentReports extentreport=new ExtentReports();
            ExtentHtmlReporter extentHtmlReporter=new ExtentHtmlReporter("D:\\VisualStudioRepos\\UnitTestProjectFramework1\\UnitTestProjectFramework1\\Reports\\");
            extentHtmlReporter.Start();
            extentreport.AddSystemInfo("Mysore", "palace");
            extentreport.AttachReporter(extentHtmlReporter);
            ExtentTest extenttest = extentreport.CreateTest("report");
            extenttest.Log(Status.Info, "This will give information");
            extenttest.Log(Status.Warning, "this is warning messege");
            extenttest.Fail("testscript failed");
            extenttest.Pass("testscript passed");
            extenttest.Info("this provides information");
            extentreport.Flush();
            extentHtmlReporter.Stop();

        }

        /*[TestMethod]
        [DataTestMethod]10
        [DataRow("Myntra","https://www.myntra.com")]
        [DataRow("Ajio","https://www.ajio.com")]
        [TestCategory("Reports")]
        public void DataDriven(string website,string url,bool test )
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            ITakesScreenshot takescreenshot =(ITakesScreenshot)driver;
            var screenshot=takescreenshot.GetScreenshot();
            screenshotpath = testresultpath + TestContext.TestName +" "+"website"+ ".png";
            screenshot.SaveAsFile(screenshotpath)
        }*/
       
    }
}
