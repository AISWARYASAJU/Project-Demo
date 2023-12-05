using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyntraDemoProject.PageObjects
{
    internal class Technology
    {

        IWebDriver driver;
        public Technology(IWebDriver driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[@href=\"https://careers.myntra.com/technology\"]\r\n")]
        [CacheLookup]
        private IWebElement? Tech { get; set; }

        public DataEngineers Technologyclick()
        {
            Thread.Sleep(3000);
            Tech?.Click();
            return new DataEngineers(driver);
            Thread.Sleep(3000);

        }
    }
}
