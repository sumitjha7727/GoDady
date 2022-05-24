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
    class EmailAndMarketing : Selenium_Base
    {
        public void GoSecurity()
        {
            open("https://www.godaddy.com/");
            wait(2000);
            click(FindXPath("//button[@id='id-0e3db3ca-f205-4a6d-8404-424f4af1d162']"));
            wait(2000);
        }
        public void GoBackToHome()
        {
            click(FindXPath("//a[@id='id-b1c657aa-b81f-4909-86bb-e349818d2dfb']"));
        }
        public string Email()
        {
            GoSecurity();
            click(FindXPath("//strong[text()='Email']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string EmailOffice()
        {
            GoSecurity();
            click(FindXPath("//a[text()='Email & Office']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string MarketingApps()
        {
            GoSecurity();
            click(FindXPath("//strong[text()='Marketing Apps & Services']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string DigitalMarketing()
        {
            GoSecurity();
            click(FindXPath("//a[text()='Digital Marketing Suite']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string ContentAndPhoto()
        {
            GoSecurity();
            click(FindXPath("//a[text()='Content & Photo Creator']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
    }
}
