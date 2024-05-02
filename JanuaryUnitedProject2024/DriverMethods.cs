using OpenQA.Selenium;

namespace JanuaryUnitedProject2024
{
    public class DriverMethods
    {
        public void FindMyElement(IWebDriver driver, string by,string locator, string value)
        {
            if (by == "Name")
            {
                driver.FindElement(By.Name(locator)).SendKeys(value);
            }
            else if (by == "css")
            {
                driver.FindElement(By.CssSelector(locator)).SendKeys(value);
            };
        }

        public IWebElement FindMyElementAndClick(IWebDriver driver, string locator)
        {
            return driver.FindElement(By.CssSelector(locator));
        }

        public IWebElement FindMyElementAndClick2(IWebDriver driver, string locator)
        {
            var element = driver.FindElement(By.CssSelector(locator));
            element.Click();
            return element; 
        }

        public IWebElement FindMyElements(IWebDriver driver, string locator)
        {
            return driver.FindElements(By.Name(locator)).First();   
        }
        public static IEnumerable<TestCaseData> Mydatas()
        {
            string[] data = {"Test010@test.com", "Password01!", " Name", "email","password"};
            yield return new TestCaseData(data);    
        }
    }
}
