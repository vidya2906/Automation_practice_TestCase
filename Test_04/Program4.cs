using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using OpenQA.Selenium;

//Test Case 4 : Is registered user is able to view and modify it's user account information?

namespace Test_04
{
    internal class Program4 : Class1
    {
        static void Main(string[] args)
        {
            Program4 test = new Program4();
            test.case4();
        }

        public void case4()
        {
            string email = "sharmavidya939@gmail.com";
            string Password1 = "Vidya@12345";
            string Password2 = "Vidya@123400";
            string confirmation = "YES";

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
            passwordBOX.SendKeys(Password1);
            Wait(1000);

            IWebElement signinBTN = FindXpath("//span[normalize-space()='Sign in']");
            signinBTN.Click();

            ScrollPage(0, 400);
            Wait(1000);

            IWebElement personalInfoBTN = FindXpath("//span[normalize-space()='My personal information']");
            personalInfoBTN.Click();
            Wait(2000);

            IWebElement fnameBOX = FindXpath("//input[@id='firstname']");
            fnameBOX.Click();
            Wait(1500);

            IWebElement lnameBOX = FindXpath("//input[@id='lastname']");
            lnameBOX.Click();
            Wait(1500);

            IWebElement emailBOX2 = FindXpath("//input[@id='email']");
            emailBOX2.Click();
            Wait(1500);

            IWebElement dayBTN = FindXpath("//select[@id='days']");
            dayBTN.Click();
            Wait(500);
            FindXpath("//*[@id='days']/option[30]").Click();
            Wait(1500);

            IWebElement monthBTN = FindXpath("//select[@id='months']");
            monthBTN.Click();
            Wait(500);
            FindXpath("//*[@id='months']/option[7]").Click();
            Wait(1500);

            IWebElement yearBTN = FindXpath("//select[@id='years']");
            yearBTN.Click();
            Wait(500);
            FindXpath("//*[@id='years']/option[24]").Click();
            Wait(1500);

            IWebElement current_PasswordBOX = FindXpath("//input[@id='old_passwd']");
            current_PasswordBOX.Click();
            current_PasswordBOX.SendKeys(Password1);
            Wait(1500);

            IWebElement new_PasswordBOX = FindXpath("//input[@id='passwd']");
            new_PasswordBOX.Click();
            new_PasswordBOX.SendKeys(Password2);
            Wait(1500);

            IWebElement confirmationBOX = FindXpath("//input[@id='confirmation']");
            confirmationBOX.Click();
            confirmationBOX.SendKeys(Password2);
            Wait(1500);

            IWebElement saveBTN = FindXpath("//span[normalize-space()='Save']");
            saveBTN.Click();
            Wait(1500);

            quit();
        }
    }
}
