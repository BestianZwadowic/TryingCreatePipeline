using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CreatingPipeline
{
    public class Tests

       
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://practicetestautomation.com/");
        }

        [Test]
        public void Test1()
        {

            string entryUrl = "https://practicetestautomation.com/";
            Assert.That(driver.Url, Is.EqualTo(entryUrl));
        }

        [TearDown]
        public void teardown1()
        {
            driver.Dispose();
        }
    }

    
}