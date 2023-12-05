using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyntraDemoProject.PageObjects
{
    internal class MyntraHomePage
    {
        IWebDriver driver;
        public MyntraHomePage(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "desktop-searchBar")]
        [CacheLookup]
        private IWebElement? SearchInputBox { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[@class='desktop-userTitle'])[2]")]
        [CacheLookup]
        private IWebElement? WishList { get; set; }


        [FindsBy(How = How.XPath, Using = "//a[@href=\"/faqs\"]")]
        [CacheLookup]
        private IWebElement? FAQ { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href=\"https://www.myntra.com/contactus\"]")]
        [CacheLookup]
        private IWebElement? ContactUs { get; set; }


        [FindsBy(How = How.XPath, Using = "//button[text()='LOG IN']")]
        [CacheLookup]
        private IWebElement? Login { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@href='/giftcard'])[3]")]
        [CacheLookup]
        private IWebElement? Gift { get; set; }


        [FindsBy(How = How.XPath, Using = "//button[text()='SEND GIFT CARD']")]
        [CacheLookup]
        private IWebElement? SendGift { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"mountRoot\"]/div/div/div[2]/div[6]/a")]
        [CacheLookup]
        private IWebElement? NextGif { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[@href='/shop/men'])[1]")]
        [CacheLookup]
        private IWebElement? Men { get; set; }

        [FindsBy(How = How.XPath, Using = "(//a[text()='Myntra Insider'])[2]")]
        [CacheLookup]
        private IWebElement? MyntraInside { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[text()='LOG IN']")]
        [CacheLookup]
        private IWebElement? LoginMyntraInsider { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href=\"https://careers.myntra.com\"]")]
        [CacheLookup]
        private IWebElement? Carrers { get; set; }

        public ExploreCareers CareersClick()
        {
            Thread.Sleep(1000);
            Carrers?.Click();
            Thread.Sleep(3000);
            return new ExploreCareers(driver);
            
        }

        public SearchedProductListPage SearchClick(string searchText)
        {
            SearchInputBox?.SendKeys(searchText);
            SearchInputBox?.SendKeys(Keys.Enter);
            return new SearchedProductListPage(driver);
        }

        public void SearchClick()
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(50);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element Not Found";
            SearchInputBox?.Click();
        }

        public void TitleTest()
        {
            Thread.Sleep(2000);
            Console.WriteLine("title " + driver.Title);

            Assert.That(driver.Title.Contains("Online Shopping"));
            Console.WriteLine("Title test - Pass");
        }

        public void OrganizationTypeTest()
        {
            Assert.That(driver.Url.Contains(".com"));
            Console.WriteLine("organization test - Pass");
        }

        public void WishClick()
        {
            WishList?.Click();
        }

        public void FAQClick()
        {
            FAQ?.Click();
        }

        public void ContactUsClick()
        {
            ContactUs?.Click();
        }

        public void LoginClick()
        {
            Login?.Click();

        }

        public void GiftClick()
        {
            Gift?.Click();
        }

        public void SendGiftClick()
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(50);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element Not Found";
            SendGift?.Click();
        }

        public void NextGFClick()
        {
            NextGif?.Click();
        }

        public void MyntraInsideClick()
        {
            MyntraInside?.Click();
        }


        public void MyntraLoginInsideClick()
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(50);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element Not Found";
            LoginMyntraInsider?.Click();
        }



      
    }










    }

