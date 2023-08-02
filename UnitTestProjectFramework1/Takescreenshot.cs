using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProjectFramework1.Objectrepo;

namespace UnitTestProjectFramework1
{
    [TestClass]
    public class Takescreenshot : Baseclass
    {
        [TestMethod]
        [TestCategory("screenshots")]
        public void Getscreenshots()
        {
            ITakesScreenshot i = (ITakesScreenshot)driver;
            Screenshot screenshot=i.GetScreenshot();
            screenshot.SaveAsFile("D:\\VisualStudioRepos\\UnitTestProjectFramework1\\UnitTestProjectFramework1\\screenshots\\veena.png", ScreenshotImageFormat.Png);
        }
    }
}
