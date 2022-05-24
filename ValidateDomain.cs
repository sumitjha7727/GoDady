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
    class ValidateDomain : Selenium_Base
    {
        public void GoToDomainNameSearch()
        {
            open("https://www.godaddy.com/");
            wait(2000);
            click(FindXPath("//button[@id='id-d6f9deab-d554-45df-a52c-8a9ab53948b5']"));
            wait(2000);
            click(FindXPath("//a[text()='Domain Name Search']"));
            wait(2000);
        }
        public string DomainNameSearch()
        {
            GoToDomainNameSearch();
            string title = Driver.Title;
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.AutoFlush = true;
            Trace.TraceInformation(title);
            close();
            return title;
        }
        public void SearchBoxPresent()
        {
            GoToDomainNameSearch();
            bool isElementDisplayed = FindXPath("//input[@name='domainToCheck']").Displayed;
            close();
        }
        public void BuyItPresent()
        {
            GoToDomainNameSearch();
            bool isElementDisplayed = FindXPath("//button[@class='btn btn-search   ']").Displayed;
            close();
        }
        public void BuyProduct()
        {
            GoToDomainNameSearch();
            sendKeys(FindXPath("//input[@name='domainToCheck']"), "mydomain");
            wait(1000);
            click(FindXPath("//button[@class='btn btn-search   ']"));
            wait(2000);
            click(FindXPath("//button[@aria-label='Add mysubdomain.co to cart']"));
            wait(3000);
            bool isElementDisplayed = FindXPath("//div[@data-cy='mysubdomain.co_spin_price']").Displayed;
            close();
        }
    }
}
