using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library
{
    public class Class1
    {
        public IWebDriver Driver;
        public IJavaScriptExecutor Js;
        public void Reference(string url)
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(url);
            Driver.Manage().Window.Maximize();
        }
        public void Wait(int t)
        {
            Thread.Sleep(t);
        }

        public void ScrollPage(int hz, int ver)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollBy(" + hz + ", " + ver + ")");
        }

        public IWebElement Findid(string id)
        {

            return Driver.FindElement(By.Id(id));

        }


        public IWebElement FindXpath(string XPath)
        {
            return Driver.FindElement(By.XPath(XPath));
        }
        public IWebElement Findxpaths(string XPaths)
        {
            return Driver.FindElements(By.XPath(XPaths))[0];
        }
        public void quit()
        {
            Task.Delay(120000).Wait();
            Driver.Close();
            Driver.Quit();
        }
    }
}
