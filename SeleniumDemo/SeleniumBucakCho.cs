using System;

using OpenQA.Selenium.Chrome;

namespace SeleniumDemo
{
    public class SeleniumBucakCho
    {



        public SeleniumBucakCho()
        {
            
            var driver = new ChromeDriver();
            
            driver.Navigate().GoToUrl("https://selenium.dev");
            
            driver.Quit();


        }
    }
}