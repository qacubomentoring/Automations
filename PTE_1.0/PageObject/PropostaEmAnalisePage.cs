using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTE_1._0.PageObject
{
    class PropostaEmAnalisePage
    {
        private IWebDriver driver;
        public PropostaEmAnalisePage(IWebDriver browser)
        {
            this.driver = browser;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }


    }
}
