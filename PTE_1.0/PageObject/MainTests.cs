using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTE_1._0.PageObject
{
    class MainTests
    {
        private static IWebDriver driver = new ChromeDriver();
        private static DateTime datahora = DateTime.Now;

        public static String GerarCpf()
        {
            int soma = 0, resto = 0;
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            Random rnd = new Random();
            string semente = rnd.Next(100000000, 999999999).ToString();

            for (int i = 0; i < 9; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;
            return semente;
        }

        public static void abreQA()
        {
            driver.Navigate().GoToUrl("http://corretor5.qa.amil.com.br");
        }

        public static void fechaBrowser()
        {
            driver.Close();
        }

        public static void loginPTE()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement login = driver.FindElement(By.Id("codigo"));
            login.SendKeys("036382");
            IWebElement password = driver.FindElement(By.Id("senha"));
            password.SendKeys("1234qwer");
            IWebElement btn_entar = driver.FindElement(By.ClassName("proximo"));
            btn_entar.Click();
        }

        public static void gerarPropostaCorretor()
        {
            var cnpj = "29309127000179";

            var wait_btn_NovaProposta = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var btn_NovaProposta = wait_btn_NovaProposta.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/as-main-app/div/as-home/section/nav/div[2]/a")));
            btn_NovaProposta.Click();

            IWebElement rdo_buttonNaoColigada = driver.FindElement(By.XPath("//label[@for = 'coligacao-nao']"));
            rdo_buttonNaoColigada.Click();

            IWebElement rdo_EmpresaMEI_Nao = driver.FindElement(By.XPath("/html/body/as-main-app//as-cotacao-condicoes-contratuais/section//form//as-empresa-detalhe//fieldset/dl[1]/dd[1]/ul/li[2]/label"));
            rdo_EmpresaMEI_Nao.Click();

            IWebElement rdo_Tabela_Compulsoria = driver.FindElement(By.XPath("/html/body/as-main-app//as-cotacao-condicoes-contratuais/section//form//as-empresa-detalhe//fieldset/dl[1]/dd[2]/ul//label[.='Compulsória']"));
            rdo_Tabela_Compulsoria.Click();

            IWebElement txtbox_CNPJ = driver.FindElement(By.Id("cnpj-empresa-0"));
            txtbox_CNPJ.SendKeys(cnpj);

            IWebElement btn_Verificar = driver.FindElement(By.CssSelector("as-empresa-detalhe dl:nth-child(2) button"));
            btn_Verificar.Click();

            IWebElement txtbox_NomeEmpresa = driver.FindElement(By.Id("nome-empresa-coligada"));
            txtbox_NomeEmpresa.SendKeys("Automação De Testes " + datahora);

            IWebElement txtbox_CEP = driver.FindElement(By.Id("cep-empresa-0"));
            txtbox_CEP.SendKeys("04555-000");

            IWebElement btn_BuscarCEP = driver.FindElement(By.CssSelector("as-empresa-detalhe dl:nth-child(3) button"));
            btn_BuscarCEP.Click();

            var wait_btnProximo = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            var btn_Proximo = wait_btnProximo.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector("[type='submit']")));
            btn_Proximo.Click();

            IWebElement checkbox_Amil = driver.FindElement(By.CssSelector("[for='16-0']"));
            checkbox_Amil.Click();

            IWebElement btn_GerarProposta = driver.FindElement(By.XPath("//button[text()='Gerar Proposta']"));
            btn_GerarProposta.Click();
        }

        public static void dadosProdutor()
        {
            IWebElement btnVincularDadosProdutor = driver.FindElement(By.XPath("//as-main-app//as-proposta/section/as-overview-proposta/div/div[1]/a[@role='button']"));
            btnVincularDadosProdutor.Click();

            IWebElement txtbox_CodCorretor = driver.FindElement(By.Id("codigo-corretor"));
            txtbox_CodCorretor.SendKeys("71308253753");

            IWebElement btn_VerificarCorretor = driver.FindElement(By.CssSelector("dd button"));
            btn_VerificarCorretor.Click();

            WebDriverWait wait_dropdown_Corretor = new WebDriverWait(driver, new TimeSpan(0, 0, 3));
            wait_dropdown_Corretor.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/as-main-app/div/as-proposta/section/as-produtor-cnpj/div[1]/div/form/fieldset/dl/dd/button")));

            IWebElement btn_VincularCorretor = driver.FindElement(By.CssSelector("fieldset .container-botao [type]"));
            btn_VincularCorretor.Click();
        }

        public static void dadosEmpresa()
        {
            var wait_btn_PreencherDadosEmpresa = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            var btn_PreencherDadosEmpresa = wait_btn_PreencherDadosEmpresa.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//as-main-app//as-proposta/section/as-overview-proposta/div/div[2]/a[@role='button']")));
            btn_PreencherDadosEmpresa.Click();

            var wait_txtbox_NomeFantReduzido = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            var txtbox_NomeFantReduzido = wait_txtbox_NomeFantReduzido.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("nome-empresa-reduzido")));
            //IWebElement txtbox_NomeFantReduzido = driver.FindElement(By.Id("nome-empresa-reduzido"));
            txtbox_NomeFantReduzido.SendKeys("automacao");

            IJavaScriptExecutor nomeFanReduzido = (IJavaScriptExecutor)driver;
            javaScript.executeScript("var txtbox_NomeFantReduzido = document.querySelector('locator'); element.value = 'Automacao';");

            IWebElement txtbox_Numero = driver.FindElement(By.Id("numero-empresa"));
            txtbox_Numero.SendKeys("1235");

            IWebElement txtbox_Complemento = driver.FindElement(By.Id("complemento-empresa"));
            txtbox_Complemento.SendKeys("Lote 1 Apto 122");

            IWebElement txtbox_NomeContato = driver.FindElement(By.Id("nome-contato"));
            txtbox_NomeContato.SendKeys("João do Teste");

            IWebElement txtbox_Cargo = driver.FindElement(By.Id("cargo"));
            txtbox_Cargo.SendKeys("Diretor de Testes");

            IWebElement txtbox_Telefone = driver.FindElement(By.Id("telefone"));
            txtbox_Telefone.SendKeys("11999999999");

            IWebElement txtbox_Email = driver.FindElement(By.Id("email"));
            txtbox_Email.SendKeys("teste@automacao.com.br");

            IWebElement btn_Avancar = driver.FindElement(By.CssSelector(".container-botao [role='button']:nth-of-type(2)"));
            btn_Avancar.Click();
        }

        public static void dadosBeneficiarioTitular()
        {

            IWebElement btn_IncluirTitular = driver.FindElement(By.ClassName("incluir-titular"));
            btn_IncluirTitular.Click();

            IWebElement txtbox_NomeCompleto = driver.FindElement(By.Id("nome-beneficiario"));
            txtbox_NomeCompleto.SendKeys("Ana Marli da Cunha");

            IWebElement txtbox_CPF = driver.FindElement(By.Id("cpfForm"));
            txtbox_CPF.SendKeys(GerarCpf());

            IWebElement txtbox_DataNascimento = driver.FindElement(By.Id("dataDeNascimentoForm"));
            txtbox_DataNascimento.SendKeys("15071970");

            SelectElement select_Sexo = new SelectElement(driver.FindElement(By.Id("sexoForm")));
            select_Sexo.SelectByText("Feminino");

            SelectElement select_EstadoCivil = new SelectElement(driver.FindElement(By.Id("estadoCivilForm")));
            select_EstadoCivil.SelectByText("Casado(a)");

            IWebElement txtbox_EmailBeneficiario = driver.FindElement(By.Id("emailForm"));
            txtbox_EmailBeneficiario.SendKeys("automatico@teste.com.br");

            IWebElement txtbox_TelefoneRes = driver.FindElement(By.Id("telefoneResidencialForm"));
            txtbox_TelefoneRes.SendKeys("11999999999");

            SelectElement select_TipoContratacao = new SelectElement(driver.FindElement(By.Id("tipo-contratacao")));
            select_TipoContratacao.SelectByIndex(1);

            IWebElement txtbox_DataAdmissao = driver.FindElement(By.Id("dataAdmissaoForm"));
            txtbox_DataAdmissao.SendKeys("08052019");

            IWebElement txtbox_CEP = driver.FindElement(By.Id("cepForm"));
            txtbox_CEP.SendKeys("04555000");

            SelectElement select_PlanoMedico = new SelectElement(driver.FindElement(By.Id("planoMedicoForm")));
            select_PlanoMedico.SelectByText("AMIL 200 QP GR. MUNIC. RM SP COPART PJCE");

            IWebElement btn_Salvar = driver.FindElement(By.CssSelector(".ng-touched .proximo"));
            btn_Salvar.Click();


                
        }
    }
}
