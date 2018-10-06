using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.PageObjects
{

    // oclass BasePage
    public class BasePage
    {

        public IWebDriver driver;
       // public BasePage(IWebDriver driver
            public BasePage(IWebDriver driver)
        {
             this.driver = driver;
                   

        }

        public void gotoGoogleHomePage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "http://www.google.com";

        }


    }
}
