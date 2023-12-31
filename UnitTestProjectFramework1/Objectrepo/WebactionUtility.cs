﻿using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectFramework1.Objectrepo
{
    /// <summary>
    /// This class is going to create the resuable webdriver methods for the scripts
    /// </summary>
    public class WebactionUtility
    {
            
            /// <summary>
            /// This method is going to provide the implicit wait.
            /// </summary>
            /// <param name="driver"></param>
            public void WaitForElementImplicitly(IWebDriver driver)
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            }
            /// <summary>
            /// This method is going to provide the explicit wait for the partial url page.
            /// </summary>
            /// <param name="driver"></param>
            /// <param name="partialpageUrl"></param>
            public void WaitForThePage(IWebDriver driver, string partialpageUrl)
            {
                WebDriverWait wdw = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                wdw.Until(ExpectedConditions.UrlContains(partialpageUrl));

            }
        }
}
