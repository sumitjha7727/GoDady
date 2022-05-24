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
    class Domain : Selenium_Base
    {
        public string GoToDomain()
        {
            open("https://www.godaddy.com/");
            wait(2000);
            click(FindXPath("//button[@id='id-d6f9deab-d554-45df-a52c-8a9ab53948b5']"));
            wait(2000);
            click(FindXPath("//a[text()='Domain Name Search']"));
            wait(2000);
            string title = Driver.Title;
            return title;
        }
        
    }
}
