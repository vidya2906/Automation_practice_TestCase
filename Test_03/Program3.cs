using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using OpenQA.Selenium;

//Test Case 3 : Can a registered user able to view all the products listed on the website?

namespace Test_03
{
    internal class Program3 : Class1
    {
        static void Main(string[] args)
        {
            Program3 test = new Program3();
            test.case3();
        }

        public void case3()
        {
            //Creating reference to browser
            Reference("http://automationpractice.com/index.php");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Wait(2000);

            IWebElement womenBTN = FindXpath("//a[@title='Women']");
            womenBTN.Click();
            Wait(1500);

            ScrollPage(0, 200);
            Wait(1000);

            ScrollPage(0, 200);
            Wait(1000);

            ScrollPage(0, 200);
            Wait(1000);

            ScrollPage(0, 200);
            Wait(1000);

            ScrollPage(0, 200);
            Wait(1000);

            ScrollPage(0, 200);
            Wait(1000);

            ScrollPage(0, 200);
            Wait(1000);

            ScrollPage(0, 200);
            Wait(1000);

            ScrollPage(0, 200);
            Wait(1000);

            quit();
        }
    }
}
