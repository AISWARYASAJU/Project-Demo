using MyntraDemoProject.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace MyntraDemoProject.PageObjects
{
    internal class SearchedFifthProduct
    {
        IWebDriver? driver;
        public SearchedFifthProduct(IWebDriver? driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }

       
        [FindsBy(How = How.XPath, Using = "(//div[@class='size-buttons-buttonContainer'])[2]")]
        [CacheLookup]
        private IWebElement? SelectedSize { get; set; }


        [FindsBy(How = How.ClassName, Using = "pdp-add-to-bag")]
        [CacheLookup]
        private IWebElement? AddToBag { get; set; }


        [FindsBy(How = How.XPath, Using = "//span[text()='Bag']")]
        [CacheLookup]
        private IWebElement? GoToBag { get; set; }

      


        //Act
        public void Sizeselect()
         {
            SelectedSize?.Click();
         }

         public void AddToBagClicked()
        {
             
            AddToBag?.Click();
         }
   
        public ViewBagProduct BagProducts()
        {
           GoToBag?.Click();
            Thread.Sleep(5000);
            return new ViewBagProduct(driver);
        }

       
    }
}
