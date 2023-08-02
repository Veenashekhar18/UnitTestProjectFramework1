using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProjectFramework1.Objectrepo;

namespace UnitTestProjectFramework1.Testscripts
{
    [TestClass]
    public class Logintoappn : Baseclass
    {
        /// <summary>
        /// This ia a test method for login action
        /// </summary>

        [TestMethod]
        [TestCategory("Login")]
        //[Ignore]
        public void Login()
        {
            Loginpage loginpage=new Loginpage(driver);
            WebactionUtility webactionUtility=new WebactionUtility();
            loginpage.username();
            loginpage.password();
            loginpage.Login();
            Console.WriteLine("login to the application");
           


           /*
                By locator = homePage.GetLogoutLink();
                webactionsLibrary.WaitForElement(driver, locator);

                homePage.Logout();
                Console.WriteLine("Logged out of the application");

            }
            /// <summary>
            /// This is a test method to click on tasks tab in home page
            /// </summary>
            [TestMethod]
            [TestCategory("tasks")]
            public void TasksMethod()
            {
                LoginPage loginPage = new LoginPage(driver);
                HomePage homePage = new HomePage(driver);
                WebactionsLibrary webactionsLibrary = new WebactionsLibrary();

                loginPage.Login("admin", "password");
                Console.WriteLine("Logged into the application");

                By locator = homePage.GetTaskTab();
                webactionsLibrary.WaitForElement(driver, locator);
                homePage.TasksClick();
                Console.WriteLine("Clicked on tasks tab");
                webactionsLibrary.WaitImplicitly(driver);
                homePage.Logout();
                Console.WriteLine("Logged out of the application");

            }
        }
        

  }
            }
}
