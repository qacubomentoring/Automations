using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTE_1._0.PageObject
{
    class SelecionarProdutoPage
    {
        private IWebDriver driver;

        public SelecionarProdutoPage(IWebDriver driver1)
        {
            this.driver = driver1;
        }

        private WebDriverWait wait => new WebDriverWait(driver, new TimeSpan(0, 0, 30));
        private IWebElement checkbox_Amil => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("[for='16-0']")));
        private IWebElement btn_GerarProposta => driver.FindElement(By.XPath("//button[text()='Gerar Proposta']"));
        private IWebElement checkbox_AmilOne => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("[for='14-0']")));
        private IWebElement checkbox_Rede => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("[for='26-0']")));
        private IWebElement checkbox_AmilFacil => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("[for='20-0']")));
        private IWebElement btn_Voltar => driver.FindElement(By.XPath("//as-main-app//as-cotacao-produto/section//form//a[@role='button']"));

        public void selecionarAmil()
        {
            checkbox_Amil.Click();
        }
        
        public void selecionarAmilOne()
        {
            checkbox_AmilOne.Click();
        }

        public void selecionarRede()
        {
            checkbox_Rede.Click();
        }

        public void selecionarAmilFacil()
        {
            checkbox_AmilFacil.Click();
        }

        public void clickBotaoGerarProposta()
        {
            btn_GerarProposta.Click();
        }
    
        public void clickBotaoVoltar()
        {
            btn_Voltar.Click();
        }
    }

}
