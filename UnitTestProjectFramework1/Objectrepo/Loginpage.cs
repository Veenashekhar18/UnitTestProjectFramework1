using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectFramework1.Objectrepo
{
    public class Loginpage
    {
        public string url = "http://localhost/login.do";
        //using FindsBy
        [FindsBy(How=How.Id,Using = "username")]
        public IWebElement usernametxt;
        [FindsBy(How=How.Name,Using="pwd")]
        public IWebElement passwordtxt;
        [FindsBy(How=How.XPath,Using = "//div[.='Login ']")]
        public IWebElement Loginbtn;
        
        public Loginpage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

       public void username()
        {
            usernametxt.SendKeys("admin");
        }
        public void password()
        {
            passwordtxt.SendKeys("manager");
        }
        public void Login()
        {
            Loginbtn.Click();
        }
    }
}
