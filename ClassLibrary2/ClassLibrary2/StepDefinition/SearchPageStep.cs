using ClassLibrary2.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ClassLibrary2.StepDefinition
{
    [Binding]
    class SearchPageStep
    {
       IWebDriver driver = new ChromeDriver();
        

        [Given(@"that I have gone to the Google page")]
        public void GivenThatIHaveGoneToTheGooglePage()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "http://www.google.com";
        }
       
        [When(@"I add ""(.*)"" to the search box")]
        public void WhenIAddToTheSearchBox(string p0)
        {            
           SearchPage searchPage = new SearchPage(driver);
            searchPage.doSearch(p0);
        }

        [When(@"click the Search Button")]
        public void WhenClickTheSearchButton()
        {
            SearchPage searchPage = new SearchPage(driver);
            searchPage.clickOnSearchbutton();
        }

        [Then(@"""(.*)"" should be mentioned in the results")]
        public void ThenShouldBeMentionedInTheResults(string p0)
        {
            Assert.AreEqual(p0, driver.FindElement(By.XPath("//input[@id='lst-ib'and @name='q']")).GetAttribute("value"));
             Console.WriteLine("Assertion passed");
                        
        }

        [Then(@"count the number of links and Display the ""(.*)""th link")]
        public void ThenCountTheNumberOfLinksAndDisplayTheThLink(int p0)
        {
            SearchPage searchPage = new SearchPage(driver);
            searchPage.displaylinkname(p0);
            searchPage.close();



        }



    }
}
