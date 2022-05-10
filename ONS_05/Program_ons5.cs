using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace ONS_05
{
    internal class Program_ons5 : Class1
    {
        static void Main(string[] args)
        {
            Program_ons5 test = new Program_ons5();
            test.Ons_5();
        }

        public void Ons_5()
        {
            //Creating reference to browser
            Reference("http://automationpractice.com/index.php");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Wait(2000);

            FindXpath("//a[@title='Women']").Click();
            Wait(2000);

            IWebElement Tshirt = FindXpath("//a[@title='Women']");

            Tshirt.Click();
            Actions action = new Actions(Driver);
            action.MoveToElement(FindXpath("//a[@title='Women']")).KeyDown(Keys.Down).Click().Perform();

            js.ExecuteScript("arguments[0].click()", Tshirt);
            Wait(5000);
            
            quit();
        }
    }
}
