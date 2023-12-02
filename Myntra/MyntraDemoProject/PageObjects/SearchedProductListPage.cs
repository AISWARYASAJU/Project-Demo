using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyntraDemoProject.PageObjects
{
    internal class SearchedProductListPage
    {
        IWebDriver? driver;
        public SearchedProductListPage(IWebDriver? driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }

        //Arrange
        [FindsBy(How = How.XPath, Using = "(//h4[@class='product-product'])[1]")]
        [CacheLookup]
        private IWebElement? SelectProduct { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\"mountRoot\"]/div/main/div[3]/div[1]/section/div/div[2]/ul/li[4]/label")]
        [CacheLookup]
        private IWebElement? FilterGirls { get; set; }

        //Act
        public SearchedFifthProduct SelectedProduct()
         {
             SelectProduct?.Click();
             return new SearchedFifthProduct(driver);
         }


        public void FilterGirlsSelected()
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(50);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element Not Found";
            
            FilterGirls?.Click();
        }
    }
}
