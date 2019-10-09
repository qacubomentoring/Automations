using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTE_1._0.Suporte;

namespace PTE_1._0.PageObject
{
    class DadosBeneficiarios
    {
        private IWebDriver driver;
        public DadosBeneficiarios(IWebDriver browser)
        {
            this.driver = browser;

        }

        private WebDriverWait wait => new WebDriverWait(driver, new TimeSpan(0, 0, 30));
        private IWebElement btn_IncluirTitular => driver.FindElement(By.ClassName("incluir-titular"));
        private IWebElement txtbox_NomeCompleto => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//as-inline-edit[@id='nome-beneficiario']//input[@id='nome-beneficiario']")));
        private IWebElement txtbox_CPF => driver.FindElement(By.XPath("/html//input[@id='cpfForm']"));
        private IWebElement txtbox_DataNascimento => driver.FindElement(By.XPath("/html//input[@id='dataDeNascimentoForm']"));
        private IWebElement select_Sexo => driver.FindElement(By.XPath("//as-select-inline-edit[@id='sexoForm']/select[@id='sexoForm']"));
        private IWebElement select_EstadoCivil => driver.FindElement(By.XPath("//as-select-inline-edit[@id='estadoCivilForm']/select[@id='estadoCivilForm']"));
        private IWebElement txtbox_EmailBeneficiario => driver.FindElement(By.XPath("//as-inline-edit[@id='emailForm']//input[@id='emailForm']"));
        private IWebElement txtbox_TelefoneRes => driver.FindElement(By.XPath("/html//input[@id='telefoneResidencialForm']"));
        private IWebElement select_TipoContratacao => driver.FindElement(By.XPath("//as-select-inline-edit[@id='tipo-contratacao']/select[@id='tipo-contratacao']"));
        private IWebElement txtbox_DataAdmissao => driver.FindElement(By.XPath("/html//input[@id='dataAdmissaoForm']"));
        private IWebElement txtbox_CEP => driver.FindElement(By.XPath("/html//input[@id='cepForm']"));
        private IWebElement btn_Buscar => driver.FindElement(By.XPath("/html/body/as-main-app//as-proposta/section/as-dados-beneficiarios//as-formulario-beneficiarios//as-formulario-titular//form/fieldset[2]/dl[1]/dd/button[@type='button']"));
        private IWebElement txtbox_NumEndereco => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//as-inline-edit[@id='numeroForm']//input[@id='numeroForm']")));
        private IWebElement select_PlanoMedico => driver.FindElement(By.XPath("//as-select-inline-edit[@id='planoMedicoForm']/select[@id='planoMedicoForm']"));
        private IWebElement msgRespondida => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(".icn-sucesso")));
        private IWebElement btn_Salvar => driver.FindElement(By.CssSelector("as-formulario-titular .proximo"));
        private IWebElement NomeTitular => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(".icn-titular")));
        private IWebElement btn_IncluirDependente => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//as-main-app//as-proposta/section/as-dados-beneficiarios//as-formulario-beneficiarios//as-formulario-titular//button[@class='incluir-dependente']")));
        private IWebElement txtbox_NomeCompletoDependente => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//as-inline-edit[@id='nome-beneficiario']//input[@id='nome-beneficiario']")));
        private IWebElement select_GrauParentesco => driver.FindElement(By.XPath("//as-select-inline-edit[@id='grau-parentesco']/select[@id='grau-parentesco']"));
        private IWebElement txtbox_NomeMae => driver.FindElement(By.XPath("//as-inline-edit[@id='nome-mae']//input[@id='nome-mae']"));
        private IWebElement btn_Avancar => driver.FindElement(By.CssSelector(".dados-beneficiario .container-botao:nth-child(5) [tabindex]"));
        private IWebElement btn_ImportarBeneficiario => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("as-modal-importar-beneficiarios button[type='button']")));
        private IWebElement btn_escolherArquivo => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("as-importar-beneficiarios-arquivo label")));
        private IWebElement btn_Importar => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("fieldset > button:nth-of-type(1)")));


        public void clicarIncluirTitular()
        {
            btn_IncluirTitular.Click();
        }

        public void inserirNomeCompleto()
        {
            txtbox_NomeCompleto.SendKeys("Ana Marli da Cunha");
        }

        public void inserirCPF()
        {
            txtbox_CPF.SendKeys(GeradorCPF.GerarCpf());
        }

        public void inserirDataNascimento()
        {
            txtbox_DataNascimento.SendKeys("15071970");
        }

        public void selecionarSexoFeminino()
        {
            select_Sexo.SendKeys("Feminino");
        }

        public void selecionarEstadoCivilCasado()
        {
            select_EstadoCivil.SendKeys("Casado(a)");
        }

        public void inserirEmail()
        {
            txtbox_EmailBeneficiario.SendKeys("automatico@teste.com.br");
        }

        public void inserirTelefone()
        {
            txtbox_TelefoneRes.SendKeys("11999999999");
        }

        public void selecionarTipoContratacaoCooperativo()
        {
            select_TipoContratacao.SendKeys("COOPERATIVO");
        }

        public void inserirDataAdmissao()
        {
            txtbox_DataAdmissao.SendKeys("08052019");
        }

        public void inserirCEP()
        {
            txtbox_CEP.SendKeys("04555000");
        }

        public void clicarBuscarCEP()
        {
            btn_Buscar.Click();
        }

        public void inserirNumEndereco()
        {
            txtbox_NumEndereco.SendKeys("12345");
        }

        public void selecionarPlanoMedico()
        {
            select_PlanoMedico.SendKeys("AMIL 200 QP GR. MUNIC. RM SP COPART PJCE");
        }

        public void clickSalvar()
        {
            btn_Salvar.Click();
        }

        public void clicarIncluirDependente()
        {
            btn_IncluirDependente.Click();
        }

        public void inserirNomeDependente()
        {
            txtbox_NomeCompletoDependente.SendKeys("Yuri Kaique Marcelo Cavalcanti");
        }

        public void inserirDataNascDependente()
        {
            txtbox_DataNascimento.SendKeys("17121989");
        }

        public void selecionarSexoMasculino()
        {
            select_Sexo.SendKeys("Masculino");
        }

        public void selecionarEstadoCivilDependente()
        {
            select_EstadoCivil.SendKeys("Casado(a)");
        }

        public void selecionarGrauParentesco()
        {
            select_GrauParentesco.SendKeys("Conjuge");
        }

        public void inserirNomeMaeDependente()
        {
            txtbox_NomeMae.SendKeys("Juliana Daniela Hadassa da Mata");
        }

        public void inserirNomeMaeTitular()
        {
            txtbox_NomeMae.SendKeys("Maria da Silva das Dores");
        }

        public void clicarBotaoAvancar()
        {
            btn_Avancar.Click();
        }

        public void clicarBotaoImportarBeneficiarios()
        {
            btn_ImportarBeneficiario.Click();
        }
        public void clicarBotaoEscolherArquivo()
        {
            btn_escolherArquivo.Click();
        }
        public void clicarBotaoImportar()
        {
            btn_Importar.Click();
        }
    }
}
