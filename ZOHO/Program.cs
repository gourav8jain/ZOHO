using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ZOHO
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver mDriver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory) { Url = "https://accounts.zoho.com/signin?servicename=zohopeople&signupurl=https://www.zoho.com/people/signup.html" };
            mDriver.Manage().Window.Maximize();
            IWebElement username = mDriver.FindElement(By.Id("lid"));
            username.Clear();
            username.SendKeys("gjain@xebia.com");
            IWebElement password = mDriver.FindElement(By.Id("pwd"));
            password.Clear();
            password.SendKeys("mckinsey@177605");
            IWebElement button = mDriver.FindElement(By.Id("signin_submit"));
            button.Click();
            Thread.Sleep(8000);
            IWebElement checkoutElement = mDriver.FindElement(By.Id("ZPD_Top_Att_Stat"));
            checkoutElement.Click();
            Thread.Sleep(5000);
            mDriver.Close();
        }
    }
}
