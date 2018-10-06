using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary2.PageObjects
{   
       class SearchPage
    {
        IWebDriver driver;
        By SearchText = By.Id("lst-ib");
        By SearchButton = By.Name("btnK");
          public SearchPage(IWebDriver driver) 
        {
            this.driver = driver;
             }
                   
        public void doSearch(String text)

        {
            driver.FindElement(SearchText).SendKeys(text);
        }
         public void clickOnSearchbutton()

        {
            driver.FindElement(SearchButton).Click();
        }
        public void displaylinkname(int link){

            IList<IWebElement> TotalLinks = driver.FindElements(By.TagName("a"));
            for(int i=0;i<TotalLinks.Count; i++)
            {
               if (i == link)
                {
                     //  Console.WriteLine(TotalLinks[i].Text);
                      Console.WriteLine(TotalLinks[i].GetAttribute("text") + "------" + TotalLinks[i].Displayed);
                    break;
                                                                                          }
                           }
                   

            }

        public void close()
        {
            driver.Quit();
        }
      
                               
    }
}
