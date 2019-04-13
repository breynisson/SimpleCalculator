using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Calculator.TestAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialize()
        {
            Instance = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }
    }
}