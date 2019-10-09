using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTE_1._0.Suporte;
using System.Threading;

namespace PTE_1._0.PageObject
{
    class AnexosPage
    {
        private IWebDriver driver;
        public AnexosPage(IWebDriver browser)
        {
            this.driver = browser;

        }

        private WebDriverWait wait => new WebDriverWait(driver, new TimeSpan(0, 0, 30));
        private IWebElement lbl_TitlePage => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html//as-main-app//h2[.='Anexos']")));
        private IWebElement select_TipoDocumento => driver.FindElement(By.XPath("//as-main-app//as-proposta/section/as-anexos/div/select[1]"));
        private IWebElement select_NomeBeneficiario => driver.FindElement(By.XPath("//as-main-app//as-proposta/section/as-anexos/div/select[2]"));
        private IWebElement btn_AnexarDoctoEmpresa => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("[for='anexar-empresa']")));
        private IWebElement btn_AnexarDoctoBeneficiarios => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("[for='anexar-beneficiario']")));        
        private IWebElement icon_eye => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//as-main-app//as-proposta/section/as-anexos//ul//button[@class='visualizar-proposta']")));
        private IWebElement btn_FinalizarProposta => driver.FindElement(By.CssSelector("[type='button']"));
        private IWebElement btn_Preencher => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("div > div:nth-of-type(4) > a[role='button']")));

        public void selecionarContratoSocial()
        {
            select_TipoDocumento.SendKeys("Contrato Social");
        }
        public void selecionarCartaoCNPJ()
        {
            select_TipoDocumento.SendKeys("Cartao CNPJ");
        }
        public void selecionarDoctoIndetFoto()
        {
            select_TipoDocumento.SendKeys("Doc. de identificacao (com foto) do responsavel legal");
        }
         public void declaracaoInformSaude()
        {
            select_TipoDocumento.SendKeys("Doc. de identificacao (com foto) do responsavel legal");
        }
        public void selecionarDeclaracaoRegularidade()
        {
            select_TipoDocumento.SendKeys("Declaração de Regularidade PJ");
        }
        public void selecionarComprovEnderecoCorresp()
        {
            select_TipoDocumento.SendKeys("Comprovante de Endereco de Correspondencia");
        }
        public void selecionarCopiaReciboInscricaoCAGED()
        {
            select_TipoDocumento.SendKeys("Copia do Recibo de inscricao do CAGED");
        }
        public void selecionarTermoResponsabilidade()
        {
            select_TipoDocumento.SendKeys("Termo de Responsabilidade (para beneficiários até 60 dias de admitidos)");
        }
        public void clicarAnexarDoctoEmpresa()
        {
            btn_AnexarDoctoEmpresa.Click();
            Thread.Sleep(2000);
            JanelasWindows.selecionarArquivoAnexo_PTE();
            Thread.Sleep(3000);
        }
        public void clicarAnexarDoctoBeneficiarios()
        {
            btn_AnexarDoctoBeneficiarios.Click();
            Thread.Sleep(2000);
            JanelasWindows.selecionarArquivoAnexo_PTE();
            Thread.Sleep(3000);
        }
        public void clicarFinalizarProposta()
        {
            btn_FinalizarProposta.Click();
        }

        public void clicarPreencher()
        {
            btn_Preencher.Click();
        }
    }
}
