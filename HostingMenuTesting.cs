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
    class HostingMenuTesting : Selenium_Base
    {
        public void GoHosting()
        {
            open("https://www.godaddy.com/");
            wait(2000);
            click(FindXPath("//button[@id='id-4bc2bcd7-65f2-4605-97a9-f29536626aac']"));
            wait(2000);
        }
        public void GoBackToHome()
        {
            click(FindXPath("//a[@id='id-b1c657aa-b81f-4909-86bb-e349818d2dfb']"));
        }
        public string WebHosting()
        {
            GoHosting();
            click(FindXPath("//a[text()='Web Hosting']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string WebHostingPlus()
        {
            GoHosting();
            click(FindXPath("//a[text()='Web Hosting Plus']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string GoDaddyBuilder()
        {
            GoHosting();
            click(FindXPath("//a[text()='GoDaddy Website Builder']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string ManageWordpress()
        {
            GoHosting();
            click(FindXPath("//a[text()='Managed WordPress Ecommerce']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string GoDaddyOnlineStoreBuilder()
        {
            GoHosting();
            click(FindXPath("//a[text()='GoDaddy Online Store Builder']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string WordPress()
        {
            GoHosting();
            click(FindXPath("//a[text()='WordPress Hosting']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string WordpressPro()
        {
            GoHosting();
            click(FindXPath("//a[text()='Managed WordPress Pro']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string WPPremium()
        {
            GoHosting();
            click(FindXPath("//a[text()='WP Premium Support']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string VPS()
        {
            GoHosting();
            click(FindXPath("//a[text()='VPS Hosting']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string VPSFully()
        {
            GoHosting();
            click(FindXPath("//a[text()='VPS - Fully Managed']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string DedicatedServer()
        {
            GoHosting();
            click(FindXPath("//a[text()='Dedicated Server']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string DedicatedServerfFully()
        {
            GoHosting();
            click(FindXPath("//a[text()='Dedicated Server - Fully Managed']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
        public string Resellers()
        {
            GoHosting();
            click(FindXPath("//a[text()='Reseller (WHMCS) Hosting']"));
            wait(2000);
            string title = Driver.Title;
            GoBackToHome();
            close();
            return title;
        }
    }
}
