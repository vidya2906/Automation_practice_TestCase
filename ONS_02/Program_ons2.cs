using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using OpenQA.Selenium;

namespace ONS_02
{
    internal class Program_ons2 : Class1
    {
        static void Main(string[] args)
        {
            Program_ons2 test = new Program_ons2();
            test.Ons_2();
        }

        public void Ons_2()
        {
            string email = "zzzzzzzzz";

            //Creating reference to browser
            Reference("http://automationpractice.com/index.php");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Wait(2000);

            ScrollPage(0, 300);
            Wait(2000);

            IWebElement loginBTN = FindXpath("//a[normalize-space()='Sign in']");
            loginBTN.Click();
            Wait(1500);

            ScrollPage(0, 300);
            Wait(1000);

            IWebElement email_BOX = FindXpath("//input[@id='email_create']");
            email_BOX.SendKeys(email);
            Wait(2000);

            IWebElement createBTN = FindXpath("//button[@id='SubmitCreate']");
            createBTN.Click();
            Wait(3000);

            IWebElement email_BOX2 = FindXpath("//input[@id='email_create']");
            email_BOX2.Click();

            quit();
        }
       
    }
}
