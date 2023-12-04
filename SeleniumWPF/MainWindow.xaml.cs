using System;
using System.Threading;
using System.Windows;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var driver = new ChromeDriver();
            
            driver.Navigate().GoToUrl("https://www.instagram.com/p/C0b1CXVPA_s/");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/section/nav/div[2]/div/div/div[2]/div/div/div/div[1]/a")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/section/main/div/div/div[1]/div[2]/form/div/div[1]/div/label/input")).SendKeys(UsernameBox.Text);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/section/main/div/div/div[1]/div[2]/form/div/div[2]/div/label/input")).SendKeys(PasswordBox.Text);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/section/main/div/div/div[1]/div[2]/form/div/div[3]/button")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/div[1]/div[2]/section/main/div/div/div/section/div/button")).Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/div[1]/div[2]/section/main/div/div/div/div[2]/div/div[4]/section/div/form/div/textarea")).SendKeys((UsernameBox.Text));
            Thread.Sleep(TimeSpan.FromSeconds(2));
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/div[1]/div[2]/section/main/div/div/div/div[2]/div/div[4]/section/div/form/div/div[2]/div")).Click();
           
            

        }
    }
}