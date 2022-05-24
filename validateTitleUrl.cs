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
    class validateTitleUrl : Selenium_Base
    {
        public string Title()
        {
            open("https://www.godaddy.com/");
            wait(2000);
            string title = Driver.Title;
            close();
            return title;
        }
        public string Url()
        {
            open("https://www.godaddy.com/");
            wait(2000);
            string url = Driver.Url;
            close();
            return url;
        }
        public string PageSource()
        {
            open("https://www.godaddy.com/");
            wait(2000);
            string pagesource = Driver.PageSource;
            close();
            return pagesource;
        }
    }
}
