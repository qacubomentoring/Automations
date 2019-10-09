using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTE_1._0.PageObject
{
    class DadosProdutorPage
    {
        private IWebDriver driver;
        public DadosProdutorPage(IWebDriver browser)
        {
            this.driver = browser;
        }

        private WebDriverWait wait => new WebDriverWait(driver, new TimeSpan(0, 0, 30));
        private IWebElement btnVincularDadosProdutor => driver.FindElement(By.XPath("//as-main-app//as-proposta/section/as-overview-proposta/div/div[1]/a[@role='button']"));
        private IWebElement txtbox_CodCorretor => driver.FindElement(By.Id("codigo-corretor"));
        private IWebElement btn_VerificarCorretor => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("dd button")));
        private IWebElement select_Supervisor => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//as-component-select[@id='supervisores']/div/span")));
        private IWebElement click_Supervisor => select_Supervisor.FindElement(By.XPath("//li[contains(.,'1 - ALEXANDRE AP. VARELA')]"));
        private IWebElement btn_VincularCorretor => driver.FindElement(By.CssSelector("fieldset .container-botao [type]"));

        public void clicarBotaoVincularDadosProdutor()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            btnVincularDadosProdutor.Click();
        }
        
        public void inserirCodCorretor()
        {
            txtbox_CodCorretor.SendKeys("71308253753");
        }

        public void clicarVerificarCorretor()
        {
            btn_VerificarCorretor.Click();
        }

        public void selecionarSupervisor()
        {
            select_Supervisor.Click();
            click_Supervisor.Click();
        }
            
        public void clicarBotaoVincular()
        {
            btn_VincularCorretor.Click();
        }

    }
}
