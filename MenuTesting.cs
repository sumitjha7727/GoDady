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
    class DomainMenuTesting : Selenium_Base
    {
        public void GoDomains()
        {
            open("https://www.godaddy.com/");
            wait(2000);
            click(FindXPath("//button[@id='id-d6f9deab-d554-45df-a52c-8a9ab53948b5']"));
            wait(2000);
        }
        public void GoBackToHome()
        {
            click(FindXPath("//a[@id='id-b1c657aa-b81f-4909-86bb-e349818d2dfb']"));
        }
        public string TransferDomainName()
        {
            GoDomains();
            click(FindXPath("//a[text()='Transfer Domain Names']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string PrivacyProtection()
        {
            GoDomains();
            click(FindXPath("//a[text()='Privacy & Protection for Domains']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string Whois()
        {
            GoDomains();
            click(FindXPath("//a[text()='WHOIS']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string Auctions()
        {
            GoDomains();
            click(FindXPath("//a[text()='Auctions for Domain Names']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string Appraise()
        {
            GoDomains();
            click(FindXPath("//a[text()='Appraise Domain Name Value']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string Investing()
        {
            GoDomains();
            click(FindXPath("//a[text()='Investing in Domains']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string Premium()
        {
            GoDomains();
            scrollPage(0, 200);
            click(FindXPath("//a[text()='Premium DNS']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
    }
}
