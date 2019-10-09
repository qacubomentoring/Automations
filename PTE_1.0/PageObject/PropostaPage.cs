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
    class PropostaPage
    {
        private IWebDriver driver;
        public PropostaPage(IWebDriver browser)
        {
            this.driver = browser;

        }

        public WebDriverWait wait => new WebDriverWait(driver, new TimeSpan(0, 0, 30));
        private string cnpj => "29309127000179";
        private String dateTime => Suporte.DataHora.dataEhoraSistema();
        public IWebElement rdo_buttonNaoColigada => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//label[contains(.,'Não')]")));
        private IWebElement rdo_EmpresaMaeNao => driver.FindElement(By.XPath("/html/body/as-main-app//as-cotacao-condicoes-contratuais/section//form//as-empresa-detalhe//fieldset/dl[1]/dd[1]/ul/li[2]/label"));
        private IWebElement rdo_EmpresaMEI_Nao => driver.FindElement(By.XPath("/html/body/as-main-app//as-cotacao-condicoes-contratuais/section//form//as-empresa-detalhe//fieldset/dl[1]/dd[1]/ul/li[2]/label"));
        private IWebElement rdo_Tabela_Compulsoria => driver.FindElement(By.XPath("//label[contains(.,'Compulsória')]"));
        private IWebElement txtbox_CNPJ => driver.FindElement(By.Id("cnpj-empresa-0"));
        private IWebElement btn_Verificar => driver.FindElement(By.CssSelector("as-empresa-detalhe dl:nth-child(2) button"));
        private IWebElement txtbox_NomeEmpresa => driver.FindElement(By.XPath("//input[@id='nome-empresa-coligada']"));
        private IWebElement txtbox_CEP => driver.FindElement(By.Id("cep-empresa-0"));
        private IWebElement btn_BuscarCEP => driver.FindElement(By.CssSelector("as-empresa-detalhe dl:nth-child(3) button"));
        private IWebElement btn_Proximo => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("[type='submit']")));


        public void selecionarNaoColigada()
        {
            //Thread.Sleep(5000);
            rdo_buttonNaoColigada.Click();
        }

        public void selecionarEmpresaMEI_Nao()
        {
            rdo_EmpresaMEI_Nao.Click();
        }

        public void selecionarTabela_Compulsoria()
        {
            rdo_Tabela_Compulsoria.Click();
        }

        public void inserirCNPJ()
        {
            txtbox_CNPJ.SendKeys(cnpj);
        }

        public void clickBotaoVerificar()
        {
            btn_Verificar.Click();
        }

        public void inserirNomeEmpresa()
        {
            txtbox_NomeEmpresa.SendKeys("Automação De Testes " + dateTime);
        }

        public void inserirCEP()
        {
            txtbox_CEP.SendKeys("04555-000");
        }

        public void clickBotãoBuscarCEP()
        {
            btn_BuscarCEP.Click();
        }

        public void clickBotaoProximo()
        {
            btn_Proximo.Click();
        }

        public void selecionarEmpresaMaeNao()
        {
            rdo_EmpresaMaeNao.Click();
        }
    }
}
