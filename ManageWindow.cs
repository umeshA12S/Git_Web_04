using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
 
namespace SeleniumAutomation
{
    public class Ex05_HandleManageWindow
    {
 
        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
 
            Thread.Sleep(3000);
 
            driver.Manage().Window.Maximize();
 
            Thread.Sleep(1000);
 
            driver.Manage().Window.FullScreen();
 
            Thread.Sleep(3000);
 
            driver.Quit();
 
 
            }
    }
}
