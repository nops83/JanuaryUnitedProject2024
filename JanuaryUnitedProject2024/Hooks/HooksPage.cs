using JanuaryUnitedProject2024.ObjectRepository;
using JanuaryUnitedProject2024.ReusableMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using static JanuaryUnitedProject2024.Enums.BrowserTypes;

namespace JanuaryUnitedProject2024.Hooks
{
    public class HooksPage: MyObjects
    {
        [SetUp] 
        public void SetUp() 
        {
            driver = ChooseBrowser(browserType.Edge); 
          //  driver.Navigate().GoToUrl(Environment.url);
            driver.Navigate().GoToUrl(Environment._url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(double.Parse(Environment.Timeout));
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(double.Parse(Environment.Timeout));
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(double.Parse(Environment.Timeout));
        }
        public IWebDriver ChooseBrowser(browserType browserType)
        {
            var browser = browserType == browserType.Chrome
                ? driver = new ChromeDriver(new CustomMethods().MaximizeChromeBrowser())
                :browserType == browserType.FireFox
                ? driver = new FirefoxDriver()
                : browserType == browserType.Edge
                ? driver = new EdgeDriver()
                : throw new Exception("No such browser exist");
                return browser;
        }
        [TearDown]  
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
            }
            driver = null;
        }
        public static IEnumerable<TestCaseData> Mydata()
        {
            string[] datas = { "https://www.automationexercise.com/login",
            "Test010@test.com",
            "Password01!" };
            yield return new TestCaseData(datas);
        }
        public static IEnumerable<TestCaseData> Mydatas()
        {
            string[] data = {
            "https://www.automationexercise.com/login", "Test010@test.com", "Password01!","password"};

            yield return new TestCaseData(data);
        }
    }
    


   

   




            

}
