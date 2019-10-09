using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTE_1._0.PageObject
{
    class DadosEmpresaPage
    {
        private IWebDriver driver;
        public DadosEmpresaPage(IWebDriver browser)
        {
            this.driver = browser;
        }

        private IWebElement lblProposta => driver.FindElement(By.CssSelector("span:nth-child(4) strong"));
        private String numProposta => lblProposta.Text;
        private WebDriverWait wait => new WebDriverWait(driver, new TimeSpan(0, 0, 30));
        private IWebElement btn_PreencherDadosEmpresa => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//as-main-app//as-proposta/section/as-overview-proposta/div/div[2]/a[@role='button']")));
        private IWebElement txtbox_NomeFantReduzido => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='nome-empresa-reduzido']")));
        private IWebElement txtbox_Numero => driver.FindElement(By.XPath("//input[@id='numero-empresa']"));
        private IWebElement txtbox_Complemento => driver.FindElement(By.XPath("//input[@id='complemento-empresa']"));
        private IWebElement txtbox_NomeContato => driver.FindElement(By.XPath("//input[@id='nome-contato']"));
        private IWebElement txtbox_Cargo => driver.FindElement(By.XPath("//input[@id='cargo']"));
        private IWebElement txtbox_Telefone => driver.FindElement(By.XPath("/html//input[@id='telefone']"));
        private IWebElement txtbox_Email => driver.FindElement(By.XPath("//as-inline-edit[@id='email']//input[@id='email']"));
        private IWebElement btn_Avancar => driver.FindElement(By.CssSelector(".container-botao [role='button']:nth-of-type(2)"));


        public void clickBotaoEditar()
        {
            btn_PreencherDadosEmpresa.Click();
        }

        public void inserirNomeFantasia()
        {
            txtbox_NomeFantReduzido.SendKeys("Automação");
        }

        public void inserirNumeroEndereco()
        {
            txtbox_Numero.SendKeys("1235");
        }

        public void inserirComplementoEndereco()
        {
            txtbox_Complemento.SendKeys("Lote 1 Apto 122");
        }

        public void inserirNomeContato()
        {
            txtbox_NomeContato.SendKeys("João do Teste");
        }

        public void inserirCargo()
        {
            txtbox_Cargo.SendKeys("Diretor de Testes");
        }

        public void inserirTelefone()
        {
            txtbox_Telefone.SendKeys("11999999999");
        }

        public void inserirEmail()
        {
            txtbox_Email.SendKeys("teste@automacao.com.br");
        }

        public void clickAvançar()
        {
            btn_Avancar.Click();
        }

    }
}
