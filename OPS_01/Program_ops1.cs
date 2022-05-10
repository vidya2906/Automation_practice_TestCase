using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using OpenQA.Selenium;


namespace OPS_01
{
    internal class Program_ops1 : Class1
    {
        static void Main(string[] args)
        {
            Program_ops1 test = new Program_ops1();
            test.Ops_1();
        }

        public void Ops_1()
        {
            string email = "kkyogwcdlqsrlatckk@nvhrw.com";

            //Creating reference to browser
            Reference("http://automationpractice.com/index.php");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

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

            #region YOUR PERSONAL INFORMATION
            string fname = "Vidya";
            string lname = "Kumari";
            string Password = "Vidya@12345";
            string company = "Bassetti India";
            string address1 = "A-1(1544)";
            string address2 = "Graduation Ln";
            string city = "Middleburg";
            string zipCode = "32068";
            string addinfo = "Not Applicable";
            string homePhone = "0";
            string mobPhone = "9113355779";
            string refAddress = " is same.";

            ScrollPage(0, 150);
            Wait(1000);

            IWebElement title_radioBTN = FindXpath("//*[@id='id_gender2']");
            title_radioBTN.Click();
            Wait(2000);

            IWebElement fnameBOX = FindXpath("//input[@id='customer_firstname']");
            fnameBOX.Click();
            fnameBOX.SendKeys(fname);
            Wait(1500);

            IWebElement lnameBOX = FindXpath("//input[@id='customer_lastname']");
            lnameBOX.Click();
            lnameBOX.SendKeys(lname);
            Wait(1500);

            IWebElement emailBOX = FindXpath("//input[@id='email']");
            emailBOX.Click();
            Wait(1500);

            IWebElement passwordBOX = FindXpath("//input[@id='passwd']");
            passwordBOX.Click();
            passwordBOX.SendKeys(Password);
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

            IWebElement checkBOX_1 = FindXpath("//input[@id='newsletter']");
            checkBOX_1.Click();
            Wait(1000);
            checkBOX_1.Click();
            Wait(1500);

            IWebElement checkBOX_2 = FindXpath("//input[@id='optin']");
            checkBOX_2.Click();
            Wait(1000);
            checkBOX_2.Click();
            Wait(1500);

            ScrollPage(0, 300);
            Wait(2000);
            #endregion

            #region YOUR ADDRESS

            IWebElement companyBOX = FindXpath("//input[@id='company']");
            companyBOX.Click();
            companyBOX.SendKeys(company);
            Wait(1500);

            IWebElement addressBOX_1 = FindXpath("//input[@id='address1']");
            addressBOX_1.Click();
            addressBOX_1.SendKeys(address1);
            Wait(1500);

            ScrollPage(0, 150);
            Wait(2000);

            IWebElement addressBOX_2 = FindXpath("//input[@id='address2']");
            addressBOX_2.Click();
            addressBOX_2.SendKeys(address2);
            Wait(1500);

            IWebElement cityBOX = FindXpath("//input[@id='city']");
            cityBOX.Click();
            cityBOX.SendKeys(city);
            Wait(1500);

            ScrollPage(0, 150);
            Wait(2000);

            IWebElement state_selectBTN = FindXpath("//select[@id='id_state']");
            state_selectBTN.Click();
            Wait(500);
            FindXpath("//*[@id='id_state']/option[11]").Click();
            Wait(1500);

            IWebElement zipCodeBOX = FindXpath("//input[@id='postcode']");
            zipCodeBOX.Click();
            zipCodeBOX.SendKeys(zipCode);
            Wait(1500);

            IWebElement country_selectBTN = FindXpath("//select[@id='id_country']");
            country_selectBTN.Click();
            Wait(500);
            FindXpath("//*[@id='id_country']/option[2]").Click();
            Wait(1500);

            ScrollPage(0, 300);
            Wait(2000);

            IWebElement addInfoBOX = FindXpath("//textarea[@id='other']");
            addInfoBOX.Click();
            addInfoBOX.SendKeys(addinfo);
            Wait(1500);

            IWebElement homePhoneBOX = FindXpath("//input[@id='phone']");
            homePhoneBOX.Click();
            homePhoneBOX.SendKeys(homePhone);
            Wait(1500);

            IWebElement mobPhoneBOX = FindXpath("//input[@id='phone_mobile']");
            mobPhoneBOX.Click();
            mobPhoneBOX.SendKeys(mobPhone);
            Wait(1500);

            IWebElement refAddressBOX = FindXpath("//input[@id='alias']");
            refAddressBOX.Click();
            refAddressBOX.SendKeys(refAddress);
            Wait(1500);

            IWebElement registerBTN = FindXpath("//span[normalize-space()='Register']");
            registerBTN.Click();
            Wait(1500);

            #endregion

            quit();
        }
    }
}
