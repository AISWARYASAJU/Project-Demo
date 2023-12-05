using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyntraDemoProject.PageObjects
{
    internal class ExploreCareers
    {
        IWebDriver driver;
        public ExploreCareers(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "(//a[@href=\"https://careers.myntra.com/jobs\"])[1]")]
        [CacheLookup]
        private IWebElement? ExpCarr { get; set; }

        public Technology ExpCareerClick()
        {
            ExpCarr?.Click();
            Thread.Sleep(3000);
            return new Technology(driver);
           

        }
    }
}
