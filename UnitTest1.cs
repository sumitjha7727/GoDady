
using System;
using DemoQASite;
using NUnit.Framework;
using System.Diagnostics;

namespace GoDaddy
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void MaximizeTesting()
        {
            MaximizeBrowser maximizeBrowser = new MaximizeBrowser();
            maximizeBrowser.MaxAndClose();
        }
        [Test]
        public void GetTitleAndUrl()
        {
            BrowserTitle browserTitle = new BrowserTitle();
            browserTitle.GetTitle();
            browserTitle.GetURL();
            browserTitle.GetPageSource();
        }

        [Test]
        public void ValidateTitle()
        {
            validateTitleUrl validateObj = new validateTitleUrl();
            string Result = validateObj.Title();

            Assert.That(Result, Is.EqualTo("Domain Names, Websites, Hosting & Online Marketing Tools - GoDaddy IN"));
        }

        [Test]
        public void ValidateUrl()
        {
            validateTitleUrl validateObj = new validateTitleUrl();
            string Result = validateObj.Url();

            Assert.That(Result, Is.EqualTo("https://www.godaddy.com/en-in"));
        }

        [Test]
        public void MatchTitle()
        {
            Domain matchObj = new Domain();
            string Result = matchObj.GoToDomain();

            Assert.That(Result, Is.EqualTo("Domain Name Search - Buy and Register Available Domains - GoDaddy IN"));
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.AutoFlush = true;
            Trace.TraceInformation("pass");
        }
        [Test]
        public void TransferDomainNameTest()
        {
            DomainMenuTesting matchObj = new DomainMenuTesting();
            string Result = matchObj.TransferDomainName();

            Assert.That(Result, Is.EqualTo("Domain Transfer | Domain Name Transferring Made Easy - GoDaddy IN"));
        }
        [Test]
        public void PrivacyProtectionTest()
        {
            DomainMenuTesting matchObj = new DomainMenuTesting();
            string Result = matchObj.PrivacyProtection();

            Assert.That(Result, Is.EqualTo("Domain Privacy & Protection | Your Domain Is Worth Protecting - GoDaddy IN"));
        }
        [Test]
        public void WhoisTest()
        {
            DomainMenuTesting matchObj = new DomainMenuTesting();
            string Result = matchObj.Whois();

            Assert.That(Result, Is.EqualTo("WHOIS | Lookup Domain Name Availability - GoDaddy IN"));
        }
        ////[Test]
        ////public void AuctionsTest()
        ////{
        ////    DomainMenuTesting matchObj = new DomainMenuTesting();
        ////    string Result = matchObj.Auctions();

        ////    Assert.That(Result, Is.EqualTo("Domain Auction | Buy & Sell Distinctive Domains - GoDaddy"));
        ////}
        [Test]
        public void AppraiseTest()
        {
            DomainMenuTesting matchObj = new DomainMenuTesting();
            string Result = matchObj.Appraise();

            Assert.That(Result, Is.EqualTo("Free Domain Value and Appraisal Tool | What is your domain worth? - GoDaddy IN"));
        }
        [Test]
        public void InvestingTest()
        {
            DomainMenuTesting matchObj = new DomainMenuTesting();
            string Result = matchObj.Investing();

            Assert.That(Result, Is.EqualTo("Domain Investing | Resources to help you get started - GoDaddy IN"));
        }
        [Test]
        public void PremiumTest()
        {
            DomainMenuTesting matchObj = new DomainMenuTesting();
            string Result = matchObj.Premium();

            Assert.That(Result, Is.EqualTo("Premium DNS Hosting | Bullet Proof DNS Security & Hosting - GoDaddy IN"));
        }
        [Test]
        public void WebHostingTest()
        {
            HostingMenuTesting match2Obj = new HostingMenuTesting();
            string Result = match2Obj.WebHosting();

            Assert.That(Result, Is.EqualTo("Web Hosting | Lightning Fast Website Hosting | 1- Click Setup - GoDaddy IN"));
        }
        [Test]
        public void WebHostingPlusTest()
        {
            HostingMenuTesting match2Obj = new HostingMenuTesting();
            string Result = match2Obj.WebHostingPlus();

            Assert.That(Result, Is.EqualTo("Web Hosting Plus - Get More Power, More Performance - GoDaddy IN"));
        }
        [Test]
        public void GoDaddyBuilderTest()
        {
            HostingMenuTesting match2Obj = new HostingMenuTesting();
            string Result = match2Obj.GoDaddyBuilder();

            Assert.That(Result, Is.EqualTo("Website Builder | Create a Free Website in Minutes - GoDaddy IN"));
        }
        [Test]
        public void ManageWordpressTest()
        {
            HostingMenuTesting match2Obj = new HostingMenuTesting();
            string Result = match2Obj.ManageWordpress();

            Assert.That(Result, Is.EqualTo("WooCommerce Hosting for your WordPress Ecommerce Site - GoDaddy IN"));
        }
        [Test]
        public void GoDaddyOnlineStoreBuilderTest()
        {
            HostingMenuTesting match2Obj = new HostingMenuTesting();
            string Result = match2Obj.GoDaddyOnlineStoreBuilder();

            Assert.That(Result, Is.EqualTo("Your Online Store Awaits | Sell Everywhere Online - GoDaddy IN"));
        }
        [Test]
        public void WordPressTest()
        {
            HostingMenuTesting match2Obj = new HostingMenuTesting();
            string Result = match2Obj.WordPress();

            Assert.That(Result, Is.EqualTo("WordPress Hosting | Fast, Secure and Reliable - GoDaddy IN"));
        }
        [Test]
        public void WordpressProTest()
        {
            HostingMenuTesting match2Obj = new HostingMenuTesting();
            string Result = match2Obj.WordpressPro();

            Assert.That(Result, Is.EqualTo("Managed WordPress Hosting for Web Pros - GoDaddy"));
        }
        //[Test]
        //public void WPPremiumTest()
        //{
        //    HostingMenuTesting match2Obj = new HostingMenuTesting();
        //    string Result = match2Obj.WPPremium();

        //    Assert.That(Result, Is.EqualTo("GoDaddy Pro | Boost Efficiency and Deliver for Your Clients - GoDaddy"));
        //}
        [Test]
        public void VPSTest()
        {
            HostingMenuTesting match2Obj = new HostingMenuTesting();
            string Result = match2Obj.VPS();

            Assert.That(Result, Is.EqualTo("VPS Hosting | A Managed Virtual Server Solution for Pros - GoDaddy IN"));
        }
        [Test]
        public void VPSFullyTest()
        {
            HostingMenuTesting match2Obj = new HostingMenuTesting();
            string Result = match2Obj.VPSFully();

            Assert.That(Result, Is.EqualTo("VPS Hosting | Fully Managed, Secure Virtual Private Servers - GoDaddy IN"));
        }
        [Test]
        public void DedicatedServerTest()
        {
            HostingMenuTesting match2Obj = new HostingMenuTesting();
            string Result = match2Obj.DedicatedServer();

            Assert.That(Result, Is.EqualTo("Dedicated Server Hosting | Get Your Own Server - GoDaddy IN"));
        }
        [Test]
        public void DedicatedServerfFullyTest()
        {
            HostingMenuTesting match2Obj = new HostingMenuTesting();
            string Result = match2Obj.DedicatedServerfFully();

            Assert.That(Result, Is.EqualTo("Get Hassle-Free Hosting with Fully Managed Dedicated Servers - GoDaddy IN"));
        }
        [Test]
        public void ResellersTest()
        {
            HostingMenuTesting match2Obj = new HostingMenuTesting();
            string Result = match2Obj.Resellers();

            Assert.That(Result, Is.EqualTo("Reseller Hosting | High-Performance for Clients - GoDaddy IN"));
        }
        [Test]
        public void SSLTest()
        {
            Security match3Obj = new Security();
            string Result = match3Obj.SSL();

            Assert.That(Result, Is.EqualTo("SSL Certificate | Secure Your Data & Transactions - GoDaddy IN"));
        }
        [Test]
        public void DVSSLTest()
        {
            Security match3Obj = new Security();
            string Result = match3Obj.DVSSL();

            Assert.That(Result, Is.EqualTo("Domain Validation SSL Certificate | Buy A DV SSL Cert Today - GoDaddy IN"));
        }
        [Test]
        public void EVSSLTest()
        {
            Security match3Obj = new Security();
            string Result = match3Obj.EVSSL();

            Assert.That(Result, Is.EqualTo("EV SSL Certificate | Buy an Extended Validation Certificate - GoDaddy IN"));
        }
        [Test]
        public void SANSSLTest()
        {
            Security match3Obj = new Security();
            string Result = match3Obj.SANSSL();

            Assert.That(Result, Is.EqualTo("SAN Certificate | Subject Alternative Name Multi Domain SSL - GoDaddy IN"));
        }
        [Test]
        public void WildcardSSLTest()
        {
            Security match3Obj = new Security();
            string Result = match3Obj.WildcardSSL();

            Assert.That(Result, Is.EqualTo("Buy a Wildcard SSL Certificate | Secure All Your Subdomains - GoDaddy IN"));
        }
        [Test]
        public void ManagedSSLTest()
        {
            Security match3Obj = new Security();
            string Result = match3Obj.ManagedSSL();

            Assert.That(Result, Is.EqualTo("Managed SSL Service | A Managed SSL Installation and Renewal Service - GoDaddy IN"));
        }
        [Test]
        public void WebSecurityTest()
        {
            Security match3Obj = new Security();
            string Result = match3Obj.WebSecurity();

            Assert.That(Result, Is.EqualTo("Website Security - Protect Your Site with GoDaddy"));
        }
        [Test]
        public void BackupTest()
        {
            Security match3Obj = new Security();
            string Result = match3Obj.Backup();

            Assert.That(Result, Is.EqualTo("Website Backup | Automated and Cloud Based Backups - GoDaddy IN"));
        }
        [Test]
        public void completeWebsecurityTest()
        {
            Security match3Obj = new Security();
            string Result = match3Obj.completeWebsecurity();

            Assert.That(Result, Is.EqualTo("Website Security - Protect Your Site with GoDaddy"));
        }
        [Test]
        public void EmailTest()
        {
            EmailAndMarketing match4Obj = new EmailAndMarketing();
            string Result = match4Obj.Email();

            Assert.That(Result, Is.EqualTo("Email & Office | Manage Productivity Anywhere - GoDaddy IN"));
        }
        [Test]
        public void EmailOfficeTest()
        {
            EmailAndMarketing match4Obj = new EmailAndMarketing();
            string Result = match4Obj.EmailOffice();

            Assert.That(Result, Is.EqualTo("Professional Business Email | Get a Business Email Account Today - GoDaddy IN"));
        }
        [Test]
        public void MarketingAppsTest()
        {
            EmailAndMarketing match4Obj = new EmailAndMarketing();
            string Result = match4Obj.MarketingApps();

            Assert.That(Result, Is.EqualTo("Digital Marketing Suite | Get Found Everywhere Online - GoDaddy"));
        }
        [Test]
        public void DigitalMarketingTest()
        {
            EmailAndMarketing match4Obj = new EmailAndMarketing();
            string Result = match4Obj.DigitalMarketing();

            Assert.That(Result, Is.EqualTo("Digital Marketing Suite | Get Found Everywhere Online - GoDaddy"));
        }
        [Test]
        public void ContentAndPhotoTest()
        {
            EmailAndMarketing match4Obj = new EmailAndMarketing();
            string Result = match4Obj.ContentAndPhoto();

            Assert.That(Result, Is.EqualTo("GoDaddy Studio | Beautiful Design Made Easy - GoDaddy IN"));
        }
        [Test]
        public void ForWebProfessionalTest()
        {
            WebProfessionals match5Obj = new WebProfessionals();
            string Result = match5Obj.ForWebProfessional();

            Assert.That(Result, Is.EqualTo("GoDaddy Pro | Boost Efficiency and Deliver for Your Clients - GoDaddy"));
        }
        [Test]
        public void DomainNameSearchTitle()
        {
            ValidateDomain titlematchObj = new ValidateDomain();
            string Result = titlematchObj.DomainNameSearch();

            Assert.That(Result, Is.EqualTo("Domain Name Search - Buy and Register Available Domains - GoDaddy IN"));
        }
        [Test]
        public void SearchBoxTest()
        {
            ValidateDomain titlematchObj = new ValidateDomain();
            titlematchObj.SearchBoxPresent();
        }
        [Test]
        public void BuyItTest()
        {
            ValidateDomain titlematchObj = new ValidateDomain();
            titlematchObj.BuyItPresent();
        }
        [Test]
        public void BuyProductTest()
        {
            ValidateDomain titlematchObj = new ValidateDomain();
            titlematchObj.BuyProduct();
        }
    }
}
