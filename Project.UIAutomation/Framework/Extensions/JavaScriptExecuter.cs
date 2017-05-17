using Framework.Components;
using OpenQA.Selenium;

namespace Framework.Extensions
{
    public class JavaScriptExecuter
    {
        internal static void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)DriverManager.Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        internal static bool IsJQueryComplete()
        {
            return (bool)((IJavaScriptExecutor)DriverManager.Driver).ExecuteScript("return jQuery.active == 0");
        }
    }
}
