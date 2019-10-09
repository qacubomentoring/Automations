using System;
using TechTalk.SpecFlow;
using PTE_1._0.PageObject;
using OpenQA.Selenium;
using PTE_1._0.Suporte;
using System.Threading;

namespace PTE_1._0
{
    [Binding]
    public class PortalPTESteps
    {
        private static IWebDriver driver = Suporte.Navegador.chromeDriver();
        private DadosBeneficiarios dadosBeneficiarios = new DadosBeneficiarios(driver);
        private LoginPage loginPage = new LoginPage(driver);
        private DadosProdutorPage dadosProdutor = new DadosProdutorPage(driver);
        private PropostaPage propostaPage = new PropostaPage(driver);
        private MainPage mainPage = new MainPage(driver);
        private AbreNavegador abreNavegador = new AbreNavegador(driver);
        private DadosEmpresaPage dadosEmpresaPage = new DadosEmpresaPage(driver);
        private DeclaracaoSaude declaracaoSaude = new DeclaracaoSaude(driver);
        private SelecionarProdutoPage selecionarProdutoPage = new SelecionarProdutoPage(driver);
        private AnexosPage anexosPage = new AnexosPage(driver);
        private Evidencias evidencias = new Evidencias(driver);
     

        [Given(@"acesso ao Portal PTE")]
        public void GivenAcessoAoPortalPTE()
        {
            abreNavegador.abreQA();
        }

        [Given(@"Realizar o Login da Corretora")]
        public void GivenRealizarOLoginDaCorretora()
        {
            loginPage.inserirUsuario();
            loginPage.inserirSenha();
            evidencias.capturaImagem();
            loginPage.clicarEntrar();
            Thread.Sleep(1000);
        }

        [Given(@"Gerar uma Proposta")]
        public void GivenGerarUmaProposta()
        {
            mainPage.clickNovaProposta();
            propostaPage.selecionarNaoColigada();
            propostaPage.selecionarEmpresaMaeNao();
            propostaPage.selecionarTabela_Compulsoria();
            propostaPage.inserirCNPJ();
            propostaPage.clickBotaoVerificar();
            propostaPage.inserirNomeEmpresa();
            propostaPage.inserirCEP();
            propostaPage.clickBotãoBuscarCEP();
            Thread.Sleep(1000);
            evidencias.capturaImagem();
            propostaPage.clickBotaoProximo();
            selecionarProdutoPage.selecionarAmil();
            Thread.Sleep(1000);
            evidencias.capturaImagem();
            selecionarProdutoPage.clickBotaoGerarProposta();
        }

        [Given(@"Preencher Dados do produtor")]
        public void GivenPreencherDadosDoProdutor()
        {
            Thread.Sleep(1000);
            evidencias.capturaImagem();
            dadosProdutor.clicarBotaoVincularDadosProdutor();
            dadosProdutor.inserirCodCorretor();
            dadosProdutor.clicarVerificarCorretor();
            dadosProdutor.selecionarSupervisor();
            Thread.Sleep(1000);
            evidencias.capturaImagem();
            dadosProdutor.clicarBotaoVincular();
        }

        [Given(@"Preencher Dados da empresa")]
        public void GivenPreencherDadosDaEmpresa()
        {
            Thread.Sleep(1000);
            evidencias.capturaImagem();
            dadosEmpresaPage.clickBotaoEditar();
            dadosEmpresaPage.inserirNomeFantasia();
            dadosEmpresaPage.inserirNumeroEndereco();
            dadosEmpresaPage.inserirNomeContato();
            dadosEmpresaPage.inserirCargo();
            dadosEmpresaPage.inserirTelefone();
            dadosEmpresaPage.inserirTelefone();
            dadosEmpresaPage.inserirEmail();
            Thread.Sleep(1000);
            evidencias.capturaImagem();
            dadosEmpresaPage.clickAvançar();
        }

        [Given(@"Preencher Dados dos beneficiários")]
        public void GivenPreencherDadosDosBeneficiarios()
        {
            Thread.Sleep(1000);
            evidencias.capturaImagem();
            dadosBeneficiarios.clicarBotaoImportarBeneficiarios();
            dadosBeneficiarios.clicarBotaoEscolherArquivo();
            JanelasWindows.selecionarPlanilhaImportacao();
            dadosBeneficiarios.clicarBotaoImportar();
        }

        [Given(@"Anexar Documentação")]
        public void GivenAnexarDocumentacao()
        {
            anexosPage.clicarPreencher();
            anexosPage.selecionarCartaoCNPJ();
            anexosPage.clicarAnexarDoctoEmpresa();
            anexosPage.selecionarContratoSocial();
            anexosPage.clicarAnexarDoctoEmpresa();
            Thread.Sleep(1000);
            evidencias.capturaImagem();
        }

        [When(@"clicar em Finalização proposta")]
        public void WhenClicarEmFinalizacaoProposta()
        {
            anexosPage.clicarFinalizarProposta();
        }

        [Then(@"Proposta deve ser enviada para Análise com Status Aguardando Análise")]
        public void ThenPropostaDeveSerEnviadaParaAnaliseComStatus()
        {
            mainPage.clickPropostasAnalise();
        }

    }


}
