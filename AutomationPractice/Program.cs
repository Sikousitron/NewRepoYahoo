using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AutomationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://login.yahoo.com/account/create?specId=yidReg&lang=es-US&src=fpctx&done=https%3A%2F%2Fespanol.yahoo.com%2F%3Fp%3Dus&display=login&intl=e1");

            try
            {
                IWebElement firstname = driver.FindElement(By.XPath("//*[@type='text']"));
                firstname.SendKeys("June");
                driver.FindElement(By.Id("usernamereg-lastName")).SendKeys("Theo");
                driver.FindElement(By.Name("yid")).SendKeys("test@yahoo.com");
                driver.FindElement(By.Name("password")).SendKeys("Syner123456789");
                driver.FindElement(By.XPath("//*[@type='tel']")).SendKeys("809-666-2510");
                driver.FindElement(By.Name("mm")).SendKeys("Diciembre");
                driver.FindElement(By.Name("dd")).SendKeys("15");
                driver.FindElement(By.Name("yyyy")).SendKeys("1998");
                driver.FindElement(By.Name("freeformGender")).SendKeys("Hombre");
                driver.FindElement(By.XPath("//*[@type='submit']")).Click();

                Console.WriteLine("Practicing QA Automation ");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();

        }
    }
}
