using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace SpecFlowProject2.Framework
{
    public class BaseObject
    {
        private static readonly WebDriver? Driver;
        //public static DefaultSelenium Selenium;

        public static void InitPage<T>(T pageClass) where T : BaseObject
        {
            
        }
    }
}