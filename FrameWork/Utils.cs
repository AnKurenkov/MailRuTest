using NUnit.Framework;

namespace SpecFlowProject2.Framework
{
    class Utils : BaseObject
    {
        public static string baseUrl = "https://account.mail.ru/login/"; 
        private const int DEFAULT_TIMEOUT_SEC = 30;

        public static void WaitForElementPresent(string locator, int timeOut = DEFAULT_TIMEOUT_SEC)
        {
            
        }
    }
}