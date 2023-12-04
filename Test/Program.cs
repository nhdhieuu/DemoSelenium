using OpenQA.Selenium.Chrome;

namespace Test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            
            driver.Navigate().GoToUrl("https://selenium.dev");
            
            driver.Quit();
        }
    }
}