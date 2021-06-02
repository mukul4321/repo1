using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumDemo
{
    class Program
    {
         IWebDriver driver = new ChromeDriver();
        
        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize()
        {
            // driver = new ChromeDriver();
            //driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://172.22.168.21/VMSNext/WebClient/Login/login.aspx?lo=true");
            Console.WriteLine("wfwfwf");
        }

        [Test]
        public void Execute()
        {
            driver.FindElement(By.Id("ctl00_c_username")).SendKeys("mukuljain");
            driver.FindElement(By.Id("ctl00_c_password")).SendKeys("xxxxxxxxxx");
            driver.FindElement(By.Id("ctl00_c_loginButton")).Click();
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }

}
