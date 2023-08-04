using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows;

namespace UnitTestProjectFramework1.ExtentReport
{
    
    public class ExtentReportgeneration
    {
        public static TestContext TestContext;
        public TestContext testContext
        {
            get {  return TestContext; }
            set { TestContext = value; }
        }
        
        const string path = "D:\\VisualStudioRepos\\UnitTestProjectFramework1\\UnitTestProjectFramework1\\Reports\\";
        public static ExtentReports extentreport;
        public static ExtentHtmlReporter extentHtmlReporter;
        public static ExtentTest extenttest;

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            TestContext = testContext;
            extentreport = new ExtentReports();
            extentHtmlReporter=new ExtentHtmlReporter(path);
            extentHtmlReporter.Start();
            extentreport.AddSystemInfo("windows", "11");
            extentreport.AttachReporter(extentHtmlReporter);
            MessageBox.Show("Assembly initialize");
        }

        [AssemblyCleanup] 
        public static void AssemblyCleanup() 
        { 
            extentreport.Flush();
            extentHtmlReporter.Stop();
            MessageBox.Show("Assembly cleanup");
        
        }

        }
    }

