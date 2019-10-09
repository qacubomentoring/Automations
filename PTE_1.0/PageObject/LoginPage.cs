using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTE_1._0.PageObject
{
    class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver browser)
        {
            this.driver = browser;

        }

        private IWebElement login => driver.FindElement(By.Id("codigo"));
        private IWebElement password => driver.FindElement(By.Id("senha"));
        private IWebElement btn_entar => driver.FindElement(By.ClassName("proximo"));

        public void inserirUsuario()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            login.SendKeys("036382");
        }

        public void inserirSenha(){
            password.SendKeys("1234qwer");
        }

        public void clicarEntrar()
        { 
            btn_entar.Click();
        }
    }
}
