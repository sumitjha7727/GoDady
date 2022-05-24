using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoQASite;

namespace GoDaddy
{
    class BrowserTitle : Selenium_Base
    {
        public string GetTitle()
        {
            open("https://www.godaddy.com/");
            wait(2000);
            string title = Driver.Title;
            close();
            return title;
        }
        public string GetURL()
        {
            open("https://www.godaddy.com/");
            wait(2000);
            string url = Driver.Url;
            close();
            return url;
        }
        public string GetPageSource()
        {
            open("https://www.godaddy.com/");
            wait(2000);
            string pagesource = Driver.PageSource;
            close();
            return pagesource;
        }
    }
}
