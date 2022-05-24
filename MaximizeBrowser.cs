using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoQASite;
using NUnit.Framework;

namespace GoDaddy
{
    class MaximizeBrowser : Selenium_Base
    {
       public void MaxAndClose()
        {
            open("https://www.godaddy.com/");
            wait(2000);
            close();
        }
    }
}
