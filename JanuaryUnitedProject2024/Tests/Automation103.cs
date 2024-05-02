using FluentAssertions;
using JanuaryUnitedProject2024.Hooks;
using OpenQA.Selenium;

namespace JanuaryUnitedProject2024.Tests
{
    public class Automation103 : HooksPage
    {
        [Test, TestCaseSource(nameof(Mydata))]
        public void TestExample03(string url, string timeout, string username, string password)
        {
            driverMethods.FindMyElement(driver, "Name", "email", "Test010@test.com");
            driverMethods.FindMyElement(driver, "Name", "password", "Password01!");
            driver.FindElement(By.CssSelector("[data-qa='login-button']")).Click();
            IWebElement loggedInName = driver.FindElement
                (By.XPath("//li//i[@class='fa fa-user']//parent::a/b"));
            var name = loggedInName.Text;
            Assert.That(name.Equals("Test010"));
            name.Should().Be("Test010");
            driver.Quit();
        }
        [Test]
        public void TaskExercise()
        {
            //driver.FindElement(By.CssSelector("[class='fc-button-label']")).Click();
            driver.FindElement(By.CssSelector("#userName")).SendKeys("TestUser");
            driver.FindElement(By.CssSelector("#password")).SendKeys("Password01!");
            driver.FindElement(By.CssSelector("#login")).Click();
            var user = driver.FindElement(By.CssSelector("userName-value")).Text;
            Assert.That(user.Equals("TestUser"),Is.True);



        }
        [Test]
        public void TaskExerciseWithMethods()
        {
            //driver.FindElement(By.CssSelector("[class='fc-button-label']")).Click();
            driver.FindElement(By.CssSelector("#userName")).SendKeys("TestUser");
            driver.FindElement(By.CssSelector("#password")).SendKeys("Password01!");
            driver.FindElement(By.CssSelector("#login")).Click();
            var user = driver.FindElement(By.CssSelector("userName-value")).Text;
            Assert.That(user.Equals("TestUser"), Is.True);



        }



    }
}