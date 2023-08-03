using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectFramework1.ExtentReport
{
    [TestClass]
    [TestCategory("Reports")]

    public class Generatereport
    {
        [TestMethod]
        
        public void Generatereports() 
        {
           ExtentReports extentreport= new ExtentReports();   
           ExtentHtmlReporter extentHtmlReporter=new ExtentHtmlReporter("D:\\VisualStudioRepos\\UnitTestProjectFramework1\\UnitTestProjectFramework1\\Reports\\");
           extentHtmlReporter.Start();
           extentreport.AddSystemInfo("name", "value");
           extentreport.AttachReporter(extentHtmlReporter);
            ExtentTest extentTest=extentreport.CreateTest("veena");
            extentTest.Pass("test passed");
            extentTest.Fail("test failed");
            extentTest.Skip("test skipped");
            extentreport.Flush();
            extentHtmlReporter.Stop();
        } 
    }
}
