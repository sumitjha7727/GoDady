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
    class Security : Selenium_Base
    {
        public void GoSecurity()
        {
            open("https://www.godaddy.com/");
            wait(2000);
            click(FindXPath("//button[@id='id-6601c18b-052d-4400-b2fc-4ba38667a59f']"));
            wait(2000);
        }
        public void GoBackToHome()
        {
            click(FindXPath("//a[@id='id-b1c657aa-b81f-4909-86bb-e349818d2dfb']"));
        }
        public string SSL()
        {
            GoSecurity();
            click(FindXPath("//strong[text()='SSL Certificates']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string DVSSL()
        {
            GoSecurity();
            click(FindXPath("//a[text()='DV SSL Certificate']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string EVSSL()
        {
            GoSecurity();
            click(FindXPath("//a[text()='EV SSL Certificate']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string SANSSL()
        {
            GoSecurity();
            click(FindXPath("//a[text()='SAN SSL']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string WildcardSSL()
        {
            GoSecurity();
            click(FindXPath("//a[text()='Wildcard SSL']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string ManagedSSL()
        {
            GoSecurity();
            click(FindXPath("//a[text()='Managed SSL Service']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string WebSecurity()
        {
            GoSecurity();
            click(FindXPath("//strong[text()='Web Security']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string Backup()
        {
            GoSecurity();
            click(FindXPath("//a[text()='Backups']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string completeWebsecurity()
        {
            GoSecurity();
            click(FindXPath("//a[text()='Complete Website Security']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
    }
}
