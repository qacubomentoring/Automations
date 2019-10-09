using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PTE_1._0.PageObject
{
    class DeclaracaoSaude
    {
        private IWebDriver driver;
        public DeclaracaoSaude(IWebDriver browser)
        {
            this.driver = browser;

        }

        WebDriverWait wait => new WebDriverWait(driver, new TimeSpan(0, 0, 30));
        private IWebElement btn_ResponderDeclaracaoSaude => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("as-modal-declaracao [type]")));
        private IWebElement btn_Proximo1 => driver.FindElement(By.CssSelector("modal-footer .container-botao [type='button']:nth-of-type(2)"));
        private IWebElement btn_Proximo2 => driver.FindElement(By.CssSelector("modal-footer .container-botao [type='button']:nth-of-type(2)"));
        private IWebElement txtbox_peso => driver.FindElement(By.XPath("//input[@id='peso']"));
        private IWebElement txtbox_altura => driver.FindElement(By.XPath("//input[@id='altura']"));
        private IWebElement btn_Finalizar => driver.FindElement(By.CssSelector("modal-footer .container-botao [type='button']:nth-of-type(2)"));


        public void preencherFormularioTitular()
        {
            btn_ResponderDeclaracaoSaude.Click();
            btn_Proximo1.Click();
            btn_Proximo2.Click();
            txtbox_peso.SendKeys("70");
            txtbox_altura.SendKeys("170");
            btn_Finalizar.Click();
        }

        public void preencherFormularioBeneficiario()
        {
            btn_ResponderDeclaracaoSaude.Click();
            btn_Proximo1.Click();
            btn_Proximo2.Click();
            txtbox_peso.SendKeys("70");
            txtbox_altura.SendKeys("170");
            btn_Finalizar.Click();
        }
    }
}
