using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using OpenQA.Selenium;

//Test Case 2 : Once registered, can a user able to login successfully?


namespace Test_02
{
    internal class Program2 : Class1
    {
        static void Main(string[] args)
        {
            Program2 test = new Program2();
            test.case2();
        }

        public void case2()
        {
            string email = "sharmavidya939@gmail.com";
            string Password = "Vidya@12345";

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

            IWebElement emailBOX = FindXpath("//input[@id='email']");
            emailBOX.Click();
            emailBOX.SendKeys(email);
            Wait(1000);

            IWebElement passwordBOX = FindXpath("//input[@id='passwd']");
            passwordBOX.Click();
            passwordBOX.SendKeys(Password);
            Wait(1000);

            IWebElement signinBTN = FindXpath("//span[normalize-space()='Sign in']");
            signinBTN.Click();

            quit();
        }
    }
}
