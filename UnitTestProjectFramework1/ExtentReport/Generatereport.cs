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
            extentreport .AddSystemInfo("aim", "goal");
            ExtentTest extenttest1=extentreport.CreateTest("Datta");
            extenttest1.Warning("this is warning messege ");
            extenttest1.Fail("test script failed");
            extenttest1.Fatal("test script failed");
            extenttest1.Pass("test script paseed");
            extentreport.AddSystemInfo("aim", "goal");
            ExtentTest extenttest2 = extentreport.CreateTest("Sushma");
            extenttest1.Warning("this is warning messege ");
            extenttest1.Fail("test script failed");
            extenttest1.Fatal("test script failed");
            extenttest1.Pass("test script passed");
            extentreport.AddSystemInfo("aim", "goal");
            ExtentTest extenttest3 = extentreport.CreateTest("Tejas");
            extenttest1.Warning("this is warning messege ");
            extenttest1.Fatal("test script failed");
            extenttest1.Fail("test script failed");
            extenttest1.Pass("test script passed");
            extentreport.Flush();
            extentHtmlReporter.Stop();
        } 
    }
}
