using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace XP_BDD_1.Tests
{
    [Binding]
    public class SampleUiFeatureSteps
    {

        private ChromeDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("disable-infobars");

            driver = new ChromeDriver(options);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }

        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            driver.Url = "http://xptehran.azurewebsites.net/home.html";
            Assert.AreEqual("FAD XP Course", driver.Title);
        }

        [When(@"I enter '(.*)' into the '(.*)' input field")]
        public void WhenIEnterIntoTheInputField(string text, string fieldId)
        {
            ScenarioContext.Current["title"] = text;
            driver.FindElement(By.Id(fieldId)).SendKeys(text);

        }

        [When(@"I click the '(.*)' control")]
        public void WhenIClickTheControl(string controlId)
        {
            driver.FindElement(By.Id(controlId)).Click();
        }

        [Then(@"'(.*)' should be displayed in the '(.*)' field")]
        public void ThenShouldBeDisplayedInTheField(string expectedText, string fieldId)
        {
            Assert.AreEqual(expectedText, driver.FindElement(By.Id(fieldId)).Text);
        }
    }
}
