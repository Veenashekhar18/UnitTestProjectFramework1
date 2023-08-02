using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput.Native;
using WindowsInput;

namespace UnitTestProjectFramework1
{
    [TestClass]
    [TestCategory("webdrivermethods")]
    public class WebDrivermethods
    {
        [TestMethod]

        public void GetUrl()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.flipkart.com";
            Thread.Sleep(1000);
            Console.WriteLine(driver.Url);
            driver.Close();
        }

        [TestMethod]
        public void Navigateurl()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            Console.WriteLine(driver.Url);
            driver.Close();

        }

        /* [TestMethod]
         public void GetTitle()
         {
             IWebDriver driver=new ChromeDriver();
             driver.Url = "https;//google.com";
             Thread.Sleep(1000);
             Console.WriteLine(driver.Title);
             driver.Close();
         }
        */
        [TestMethod]
        public void Findelement()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com";
            Console.WriteLine(driver.Title);
            driver.FindElement(By.Id("APjFqb")).SendKeys("flipkart");
        }

        [TestMethod]
        public void Findelements()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com";
            ReadOnlyCollection<IWebElement> element = driver.FindElements(By.XPath("/a"));
            Console.WriteLine("all the links in google page " + element);
        }

        [TestMethod]

        public void Pagesource()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.amazon.com";
            string pagesource = driver.PageSource;
            Console.WriteLine("pagesource = " + pagesource);
        }

        [TestMethod]
        public void WindowHandle()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.myntra.com";
            string windowhandle = driver.CurrentWindowHandle;
            Console.WriteLine(windowhandle);
        }

        [TestMethod]
        public void WindowHandles()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.myntra.com";
            IWebElement element = driver.FindElement(By.XPath("//a"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element).ContextClick().Build().Perform();
            KeyboardSimulator keyboardsimulator = new KeyboardSimulator(new InputSimulator());
            keyboardsimulator.KeyPress(VirtualKeyCode.DOWN);
            keyboardsimulator.KeyPress(VirtualKeyCode.RETURN);
            ReadOnlyCollection<string> windowId = driver.WindowHandles;
            foreach (string id in windowId)
            {
                Console.WriteLine(id);
            }


        }

        [TestMethod]
        public void Closemethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.amazon.com";
            Thread.Sleep(1000);
            driver.Close();
        }

        [TestMethod]
        public void QuitProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "htps://www.google.com";
            driver.Quit();
        }

        [TestMethod]
        public void NavigateRefresh()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.com");
            driver.Navigate().Refresh();
        }

        [TestMethod]

        public void ManageProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.com");
            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void Switchproprty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.com");
            driver.SwitchTo().Window("");
        }

    }

}
