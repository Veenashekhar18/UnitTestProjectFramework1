using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnitTestProjectFramework1
{
    [TestClass]
    public class WebElementMethods
    {
        [TestMethod]
        public void TagNamemethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.myntra.com");
            IWebElement element = driver.FindElement(By.XPath(""));
            string tagname = element.TagName;
            Console.WriteLine(tagname);
        }

        [TestMethod]

        public void EnabledProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.myntra.com");
            IWebElement element = driver.FindElement(By.Id(""));
            bool enabled = element.Enabled;
            Console.WriteLine("Here we will get to know elemnt is enabled or not " + enabled);
        }

        [TestMethod]
        public void SelectProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.actitime.com/login.do";
            IWebElement element = driver.FindElement(By.Id("keepLoggedInCheckBox"));
            bool checkbox = element.Selected;
            Console.WriteLine("Check whether element is selected or not " + checkbox);
        }

        [TestMethod]
        public void LocationProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.actitime.com/login.do";
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            IWebElement element = driver.FindElement(By.Name("username"));
            Point location = element.Location;
            Console.WriteLine("get the loaction " + location);
        }
        [TestMethod]
        public void SizeProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.actitime.com/login.do";
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            IWebElement element = driver.FindElement(By.Name("username"));
            Size size = element.Size;
            Console.WriteLine("get the size of an element " + size);
        }

        [TestMethod]
        public void TextProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            IWebElement element = driver.FindElement(By.XPath("//a[text()='Gmail']"));
            String text = element.Text;
            Console.WriteLine("Get the text of element" + text);
        }

        [TestMethod]
        public void DisplayProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.actitime.com/login.do";
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            IWebElement element = driver.FindElement(By.Id("[id='headerContainer']"));
            bool disp = element.Displayed;
            Console.WriteLine("Check the messege is displayed " + disp); ;
        }
        [TestMethod]
        public void ClearProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.actitime.com/login.do";
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            Thread.Sleep(3000);
            driver.FindElement(By.Name("username")).Clear();
        }

        [TestMethod]
        public void SendkeysProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.actitime.com/login.do";
            driver.FindElement(By.Name("username")).SendKeys("Admin");
        }

        [TestMethod]
        public void SubmitProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.actitime.com/login.do";
            IWebElement element = driver.FindElement(By.Name("username"));
            element.SendKeys("Admin");
            element.Submit();
        }
        [TestMethod]
        public void ClickProperty()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.actitime.com/login.do";
            IWebElement element = driver.FindElement(By.Name("username"));
            element.Click();
        }


    }
}
