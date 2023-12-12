using System;
using System.Threading;
using System.Windows;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace SeleniumWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        // {
        //     var driver = new ChromeDriver();
        //     
        //     //chuyển tới trang
        //     driver.Navigate().GoToUrl("https://www.instagram.com/p/C0b1CXVPA_s/");
        //     Thread.Sleep(TimeSpan.FromSeconds(5));
        //     driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/section/nav/div[2]/div/div/div[2]/div/div/div/div[1]/a")).Click();
        //     Thread.Sleep(TimeSpan.FromSeconds(2));
        //     
        //     //Điền username và password
        //     driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/section/main/div/div/div[1]/div[2]/form/div/div[1]/div/label/input")).SendKeys("duylam1412");
        //     Thread.Sleep(TimeSpan.FromSeconds(2));
        //     driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/section/main/div/div/div[1]/div[2]/form/div/div[2]/div/label/input")).SendKeys("duyhieu123");
        //     Thread.Sleep(TimeSpan.FromSeconds(2));
        //     
        //     //Đăng nhập
        //     driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/section/main/div/div/div[1]/div[2]/form/div/div[3]/button")).Click();
        //     Thread.Sleep(TimeSpan.FromSeconds(10));
        //     
        //     
        //     //Bỏ qua thông báo
        //     driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/div[1]/div[2]/section/main/div/div/div/div/div")).Click();
        //     Thread.Sleep(TimeSpan.FromSeconds(2));
        //     // driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/div[1]/div[2]/section/main/div/div/div/div[2]/div/div[4]/section/div/form/div/textarea")).SendKeys((UsernameBox.Text));
        //     
        //     //Điền cmt vào ô
        //     IWebElement textarea = driver.FindElement(By.TagName("textarea"));
        //     textarea.Click();
        //     textarea = driver.FindElement(By.TagName("textarea"));
        //     textarea.SendKeys("sadasd");
        //     
        //     //Gửi cmt
        //     driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/div[1]/div[2]/section/main/div/div/div/div[2]/div/div[4]/section/div/form/div/div[2]/div")).Click();
        //    
        //     
        //
        // }
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var driver = new ChromeDriver();

            //chuyển tới trang
            driver.Navigate().GoToUrl("https://www.instagram.com/");
            Thread.Sleep(TimeSpan.FromSeconds(3));

            //Điền username và password
            driver.FindElement(By.XPath(
                    "/html/body/div[2]/div/div/div[2]/div/div/div[1]/section/main/article/div[2]/div[1]/div[2]/form/div/div[1]/div/label/input"))
                .SendKeys("duylam1412");
            driver.FindElement(By.XPath(
                    "/html/body/div[2]/div/div/div[2]/div/div/div[1]/section/main/article/div[2]/div[1]/div[2]/form/div/div[2]/div/label/input"))
                .SendKeys("duyhieu123");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            //Đăng nhập
            driver.FindElement(By.XPath(
                    "/html/body/div[2]/div/div/div[2]/div/div/div[1]/section/main/article/div[2]/div[1]/div[2]/form/div/div[3]/button/div")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));

            driver.Navigate().GoToUrl("https://www.instagram.com/explore/");
            Thread.Sleep(TimeSpan.FromSeconds(3));

            ScrollTo(100,100, driver);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/div[1]/div[2]/section/main/div/div[1]/div/div[6]/div[2]/div/a/div/div[2]")).Click();
            
                

        }

        public void ScrollTo(int xPosition, int yPosition, ChromeDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }
    }
}