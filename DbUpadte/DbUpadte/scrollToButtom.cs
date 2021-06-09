using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbUpadte
{
    class scrollToButtom
    {
        public string Url { get; set; }
        public IWebDriver driver = new ChromeDriver();
        public IList<IWebElement> ScrollRead { get; set; }

        public scrollToButtom(string url)
        {
            ScrollRead = scroll(url, driver);
            Url = url;
            //driver.Close();
        }

        public IList<IWebElement> scroll(string url, IWebDriver driver)
        {
            //IWebDriver driver = new FirefoxDriver();
            driver.Url = url;
            
           var cookiespages = driver.FindElement(By.XPath("/html/body/div/c-wiz/div/div/div/div[2]/div[1]/div[4]/form/div[1]/div/button"));

            if (cookiespages != null)
            {
                cookiespages.Click();
            }

            //System.Threading.Thread.Sleep(1000);

            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            //System.Threading.Thread.Sleep(1000);

            IList<IWebElement> list = driver.FindElements(By.XPath("//a[@id='video-title']"));
            int initialCount = list.Count;
            js.ExecuteScript("window.scrollBy(0,2000)");
            System.Threading.Thread.Sleep(600);

            list = driver.FindElements(By.XPath("//a[@id='video-title']"));

            while (list.Count != initialCount)
            {
                js.ExecuteScript("window.scrollBy(0,2000)");
                System.Threading.Thread.Sleep(600);

                list = driver.FindElements(By.XPath("//a[@id='video-title']"));
                initialCount = list.Count;
                
                js.ExecuteScript("window.scrollBy(0,2000)");
                System.Threading.Thread.Sleep(600);
                list = driver.FindElements(By.XPath("//a[@id='video-title']"));
            }
                     
            //driver.Close();
            return list; 
            
            //Console.WriteLine(list[0].GetAttribute("href"));
            //js.ExecuteScript("window.scrollBy(0,1000)");
            //Console.Read();
        
        }

    }
}
