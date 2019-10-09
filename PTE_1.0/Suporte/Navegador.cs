using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTE_1._0.Suporte
{
    class Navegador
    {
        public static IWebDriver chromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            return driver;
        }
        public static void fechaBrowser()
        {
            Navegador.chromeDriver().Close();
        }
    }
}
