using OpenQA.Selenium;

namespace SpecFlowProject2.Pages
{
    public class HomePage
    {
        protected WebDriver driver;

        private By userNameBy = By.CssSelector("span[class^='ph-project__user-name']");

        public HomePage(WebDriver driver)
        {
            this.driver = driver;
        }

        public String GetUsername()
        {
            String userName = driver.FindElement(userNameBy).Text;
            return userName;
        }
    }
}
