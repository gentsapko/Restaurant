using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace RestaurantAutomation
{
    public class Class1
    {
        public void Go()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://restaurant-12.apphb.com/");
        }
    }
}
