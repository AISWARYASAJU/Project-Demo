using MyntraDemoProject.PageObjects;
using MyntraDemoProject.Utilities;
using OpenQA.Selenium.Interactions;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyntraDemoProject.TestScripts
{
    [TestFixture]
    internal class TestScriptsSmoke: CoreCodes
    {
        [Test]
        [Order(1)]

        public void TitleSearch()
        {
            string? currdir = Directory.GetParent(@"../../../")?.FullName;
            string? logfilepath = currdir + "/Logs/log_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File(logfilepath, rollingInterval: RollingInterval.Day)
            .CreateLogger();

            driver.Navigate().GoToUrl("https://www.myntra.com/");

            var title = new MyntraHomePage(driver);
            title.TitleTest();

            try
            {
                Assert.That(driver?.Url, Is.EqualTo("https://www.myntra.com/"));
                Log.Information("Test Passed for Home Page");
                test = extent.CreateTest("Home Page Test");
                test.Pass("Test success");

            }
            catch (AssertionException ex)
            {
                Log.Error($" Test failed for Home page. \n Exception: {ex.Message}");
                test = extent.CreateTest("Home page Test");
                test.Fail("test Failed");

            }

        }

        [Test]
        [Order(2)]
        public void OrganizationSearch()
        {
            string? currdir = Directory.GetParent(@"../../../")?.FullName;
            string? logfilepath = currdir + "/Logs/log_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File(logfilepath, rollingInterval: RollingInterval.Day)
            .CreateLogger();

            driver.Navigate().GoToUrl("https://www.myntra.com/");

            var org = new MyntraHomePage(driver);
            org.OrganizationTypeTest();

            try
            {
                Assert.That(driver?.Url, Is.EqualTo("https://www.myntra.com/"));
                Log.Information("Test Passed for Organization Page");
                test = extent.CreateTest(" Test");
                test.Pass("Test success for Organization");

            }
            catch (AssertionException ex)
            {
                Log.Error($" Test failed for  Organization page. \n Exception: {ex.Message}");
                test = extent.CreateTest("Organization page Test");
                test.Fail("test Failed");

            }
        }

        [Test]
        [Order(3)]
        public void WishListSearch()

        {
            string? currdir = Directory.GetParent(@"../../../")?.FullName;
            string? logfilepath = currdir + "/Logs/log_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File(logfilepath, rollingInterval: RollingInterval.Day)
            .CreateLogger();
            driver.Navigate().GoToUrl("https://www.myntra.com/");

            var wish = new MyntraHomePage(driver);
            wish.WishClick();
           // Thread.Sleep(3000);

            try
            {
                Assert.That(driver?.Url, Is.EqualTo("https://www.myntra.com/wishlist"));
                Log.Information("Test Passed for Wishlist ");
                test = extent.CreateTest(" Test");
                test.Pass("Test success for WishList");

            }
            catch (AssertionException ex)
            {
                Log.Error($" Test failed for wishlist Button. \n Exception: {ex.Message}");
                test = extent.CreateTest("WishList page Test");
                test.Fail("test Failed");

            }

        }

        [Test]
        [Order(4)]
        public void FAQSearch()
        {
            string? currdir = Directory.GetParent(@"../../../")?.FullName;
            string? logfilepath = currdir + "/Logs/log_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File(logfilepath, rollingInterval: RollingInterval.Day)
            .CreateLogger();
            driver.Navigate().GoToUrl("https://www.myntra.com/");

            var faq = new MyntraHomePage(driver);
            faq.FAQClick();
            Thread.Sleep(3000);
            faq.ContactUsClick();
            faq.LoginClick();

            try
            {
                Assert.That(driver?.Url, Is.EqualTo("https://www.myntra.com/login?referer=https%3A%2F%2Fwww.myntra.com%2Fcontactus"));
                Log.Information("Test Passed for Faq ");
                test = extent.CreateTest(" Test PAssed for FAQ");
                test.Pass("Test success for Faq");

            }
            catch (AssertionException ex)
            {
                Log.Error($" Test failed for FAQ. \n Exception: {ex.Message}");
                test = extent.CreateTest(" FAQ page Test");
                test.Fail("test Failed");

            }

        }

        [Test]
        [Order(5)]
        public void GiftSearch()
        {
            string? currdir = Directory.GetParent(@"../../../")?.FullName;
            string? logfilepath = currdir + "/Logs/log_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File(logfilepath, rollingInterval: RollingInterval.Day)
            .CreateLogger();
            driver.Navigate().GoToUrl("https://www.myntra.com/");
            var gif = new MyntraHomePage(driver);
            gif.GiftClick();
            Thread.Sleep(3000);
            gif.SendGiftClick();
            Thread.Sleep(3000);
            gif.NextGFClick();

            try
            {
                Assert.That(driver?.Url, Is.EqualTo("https://www.myntra.com/login?referer=/giftcard/buy"));
                Log.Information("Test Passed for Gifts ");
                test = extent.CreateTest(" Test PAssed");
                test.Pass("Test success for Giftsearch");

            }
            catch (AssertionException ex)
            {
                Log.Error($" Test failed for gifts Button. \n Exception: {ex.Message}");
                test = extent.CreateTest("WishList page Test");
                test.Fail("test Failed");

            }
        }



        /*  public void MenMouseOver()
          {
              Actions actions = new Actions(driver);
              Action mouseOverClick = () => actions.MoveToElement(Men).Build().Perform();
              mouseOverClick.Invoke();


          }
        */

        [Test]
        [Order(6)]
        public void MyntraInsideSearch()
        {
            string? currdir = Directory.GetParent(@"../../../")?.FullName;
            string? logfilepath = currdir + "/Logs/log_" +
                DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File(logfilepath, rollingInterval: RollingInterval.Day)
            .CreateLogger();
            driver.Navigate().GoToUrl("https://www.myntra.com/");
            var inside = new MyntraHomePage(driver);
            inside.MyntraInsideClick();
            inside.MyntraLoginInsideClick();

            try
            {
                Assert.That(driver?.Url, Is.EqualTo("https://www.myntra.com/login?referer=https://www.myntra.com/myntrainsider?cache=false"));
                Log.Information("Test Passed for insider ");
                test = extent.CreateTest(" Test insider");
                test.Pass("Test success for insider");

            }
            catch (AssertionException ex)
            {
                Log.Error($" Test failed for insider. \n Exception: {ex.Message}");
                test = extent.CreateTest("Myntra insider page Test");
                test.Fail("test Failed");

            }
        }



    }
}
