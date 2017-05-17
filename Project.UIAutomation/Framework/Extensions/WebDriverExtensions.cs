using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;

namespace Framework.Extensions
{
    public static class WebDriverExtensions
    {
        internal static void WaitForElement(this IWebDriver driver, By by, int secondsToWait = 30)
        {
            var timeout = new TimeSpan(0, 0, secondsToWait);
            var sw = new Stopwatch();
            bool found = false;

            sw.Start();
            while (!found && sw.ElapsedMilliseconds < timeout.TotalMilliseconds)
            {
                var elements = driver.FindElements(by);
                if (elements.Any())
                {
                    found = true;
                }
                else
                {
                    Thread.Sleep(500);
                }
            }
            if (!found)
            {
                throw new NoSuchElementException("Could not locate element: " + by.ToString() + " within " + secondsToWait + " seconds");
            }
        }

        internal static void WaitForAjax(this IWebDriver driver, int secondsToWait = 60)
        {
            var timeout = new TimeSpan(0, 0, secondsToWait);
            var sw = new Stopwatch();
            bool done = false;

            sw.Start();
            while (!done && sw.ElapsedMilliseconds < timeout.TotalMilliseconds)
            {
                done = JavaScriptExecuter.IsJQueryComplete();

                if (!done)
                {
                    Thread.Sleep(500);
                }
            }
            if (!done)
            {
                throw new TimeoutException("WaitForAjax did not complete within " + secondsToWait + " seconds");
            }
        }
    }
}
