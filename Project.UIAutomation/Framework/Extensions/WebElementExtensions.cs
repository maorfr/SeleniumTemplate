using System;
using System.Diagnostics;
using System.Threading;
using OpenQA.Selenium;
using Framework.Components;

namespace Framework.Extensions
{
    public static class WebElementExtensions
    {
        internal static void ClearAndSendKeys(this IWebElement element, string keys)
        {
            JavaScriptExecuter.ScrollToElement(element);
            element.Clear();
            element.SendKeys(keys);
        }

        internal static void ClickAndWait(this IWebElement element)
        {
            JavaScriptExecuter.ScrollToElement(element);
            element.Click();
            DriverManager.Driver.WaitForAjax();
        }
    }
}
