using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumBasic;

public class SimpleDriver
{
    public IWebDriver Driver
    {
        get
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            return new ChromeDriver(path + @"/Resources/");
        }
    }
}