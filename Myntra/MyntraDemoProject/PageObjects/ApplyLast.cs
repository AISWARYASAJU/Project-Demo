using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyntraDemoProject.PageObjects
{
    internal class ApplyLast
    {
        IWebDriver driver;
        public ApplyLast(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//a[@href=\"javascript:void()\"]")]
        [CacheLookup]
        private IWebElement? lastbutton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='text' and @name='first_name']")]
        private IWebElement? FirstNameInputBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='text' and @name='last_name']")]
        private IWebElement? LastNameInputBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='email' and @name='email']")]
        private IWebElement? EmailInputBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='text' and @name='phone']")]
        private IWebElement? PhoneNum { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='text' and @name='location']")]
        private IWebElement? Location { get; set; }

        public void LastButtonClick()
        {
            Thread.Sleep(3000);
            lastbutton?.Click();
            Thread.Sleep(3000);

        }

        public void ApplyNow(string firstName, string lastName, string email,
            string mbno, string location)
        {
            Thread.Sleep(5000);
            FirstNameInputBox?.SendKeys(firstName);
            LastNameInputBox?.SendKeys(lastName);
            EmailInputBox?.SendKeys(email);
            PhoneNum?.SendKeys(mbno);
            Location?.SendKeys(location);
        }
       
    }
}
