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
    class WebProfessionals : Selenium_Base
    {
        public string ForWebProfessional()
        {
            open("https://www.godaddy.com/");
            wait(2000);
            click(FindXPath("//button[@id='id-261a403f-f6be-4a7e-b813-786437bf5589']"));
            wait(2000);
            click(FindXPath("//a[@id='id-897493ae-b03b-4e54-99f8-06280d0088a0']"));
            wait(2000);
            string title = Driver.Title;
            close();
            return title;
        }
    }
}
