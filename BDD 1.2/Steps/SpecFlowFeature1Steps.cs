using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace BDD_1._2.Steps
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        protected IWebDriver driver;

        [Given(@"I have opened ""(.*)""")]
        public void GivenIHaveOpened(string URL)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Url = URL;

        }
        
        [When(@"I click ""(.*)""")]
        public void WhenIClick(string ID)
        {
            IWebElement sendButton1 = driver.FindElement(By.LinkText(ID));
            sendButton1.Click();          
        }
        
        [Then(@"the Yandex\.Market main page is presented")]
        public void ThenTheYandex_MarketMainPageIsPresented()
        {

            Assert.IsNotNull(driver.FindElement(By.ClassName("logo_part_market")));

            driver.Quit();

        }
    }
}
