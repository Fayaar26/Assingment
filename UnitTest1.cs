using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assingment
{
    public class Tests
    {
        IWebDriver browser;
        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized");
            browser = new ChromeDriver(options);
            browser.Navigate().GoToUrl(Link.url);
        }

        [Test]
        public void Test1()
        {
            browser.FindElement(By.PartialLinkText("Signup")).Click();
            browser.FindElement(By.XPath("//input[@placeholder='Name']")).SendKeys("Lanre");
            browser.FindElement(By.XPath("//input[@data-qa='signup-email']")).SendKeys($"dune{new Random().Next(1, 999)}@yahoo.com");
            browser.FindElement(By.CssSelector("[data-qa='signup-button']")).Click();
            browser.FindElements(By.TagName("input"))[1].Click();
            browser.FindElement(By.Id("password")).SendKeys("bababa");
            
            SelectElement daydown = new SelectElement(browser.FindElement(By.Id("days")));
             daydown.SelectByText("10");
            SelectElement monthdown = new SelectElement(browser.FindElement(By.Id("months")));
             monthdown.SelectByText("October");
            SelectElement yeardown = new SelectElement(browser.FindElement(By.Id("years")));
             yeardown.SelectByText("1980");

            browser.FindElement(By.XPath("//input[@data-qa='first_name']")).SendKeys("wale");
            browser.FindElement(By.XPath("//input[@data-qa='last_name']")).SendKeys("zainab");
            browser.FindElement(By.XPath("//input[@data-qa='company']")).SendKeys("De fayaar nig ltd");
            browser.FindElement(By.XPath("//input[@data-qa='address']")).SendKeys("30,fISH ROAD");
            browser.FindElement(By.XPath("//input[@data-qa='address2']")).SendKeys("LONDON");
            SelectElement countrydown = new SelectElement(browser.FindElement(By.Id("country")));
            countrydown.SelectByText("New Zealand");
            browser.FindElement(By.XPath("//input[@data-qa='state']")).SendKeys("sheffield"); 
            browser.FindElement(By.XPath("//input[@data-qa='city']")).SendKeys("ogun");

            browser.FindElement(By.XPath("//input[@data-qa='zipcode']")).SendKeys("rmgh1p"); 
            browser.FindElement(By.XPath("//input[@data-qa='mobile_number']")).SendKeys("07082693120");
            //((IJavaScriptExecutor)browser).ExecuteScript("window.scrollBy(0, 250)");
            //browser.FindElement(By.CssSelector("[data-qa='create-account']")).Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)browser;
            js.ExecuteScript("arguments[0].click();", browser.FindElement(By.CssSelector("[data-qa='create-account']")));


            browser.FindElement(By.CssSelector("[data-qa='continue-button']")).Click();


        }

        [TearDown]
        public void TearDown()
        {
            
        }
    }
}