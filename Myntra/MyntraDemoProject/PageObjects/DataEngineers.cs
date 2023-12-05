using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyntraDemoProject.PageObjects
{
    internal class DataEngineers
    {
        IWebDriver driver;
        public DataEngineers(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "(//a[@href=\"https://careers.myntra.com/job-detail/?id=6968718002\"])[2]\r\n")]
        [CacheLookup]
        private IWebElement? DataEn { get; set; }

        public ApplyLast DataEngClick()
        {
            Thread.Sleep(3000);
            DataEn?.Click();
            Thread.Sleep(3000);
            return new ApplyLast(driver);

        }
    }
}
