using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PTE_1._0.Suporte;

namespace PTE_1._0.PageObject
{
    class AbreNavegador
    {
        private IWebDriver driver;
        public AbreNavegador(IWebDriver browser)
        {
            this.driver = browser;

        }

        public void abreQA()
        {
            driver.Navigate().GoToUrl("http://corretor8.qa.amil.com.br");
        }
    }
}
