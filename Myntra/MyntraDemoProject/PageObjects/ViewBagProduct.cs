using MyntraDemoProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.DOM;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace MyntraDemoProject.PageObjects
{
    internal class ViewBagProduct
    {
        IWebDriver driver;
        public ViewBagProduct(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[text()='PLACE ORDER']//parent::button")]
        [CacheLookup]
        private IWebElement? PlaceOrderButton { get; set; }

        public void PlaceOrderClicked()
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(50);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element Not Found";
            PlaceOrderButton?.Click();
            
        }

        



    }
}
