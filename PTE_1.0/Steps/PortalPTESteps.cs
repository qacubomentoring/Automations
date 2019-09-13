using System;
using TechTalk.SpecFlow;
using PTE_1._0.PageObject;

namespace PTE_1._0
{
    [Binding]
    public class PortalPTESteps
    {
        [Given(@"acesso ao Portal PTE")]
        public void GivenAcessoAoPortalPTE()
        {
            MainTests.abreQA();
        }
        
        [Given(@"Realizar o Login da Corretora")]
        public void GivenRealizarOLoginDaCorretora()
        {
            MainTests.loginPTE();
        }
        
        [Given(@"Gerar uma Proposta")]
        public void GivenGerarUmaProposta()
        {
            MainTests.gerarPropostaCorretor();
        }
        
        [Given(@"Preencher Dados do produtor")]
        public void GivenPreencherDadosDoProdutor()
        {
            MainTests.dadosProdutor();
        }
        
        [Given(@"Preencher Dados da empresa")]
        public void GivenPreencherDadosDaEmpresa()
        {
            MainTests.dadosEmpresa();
        }
        
        [Given(@"Preencher Dados dos beneficiários")]
        public void GivenPreencherDadosDosBeneficiarios()
        {
            MainTests.dadosBeneficiarioTitular();
        }
        
        [Given(@"Anexar Documentação")]
        public void GivenAnexarDocumentacao()
        {
            
        }
        
        [When(@"clicar em Finalização proposta")]
        public void WhenClicarEmFinalizacaoProposta()
        {
            
        }
        
        [Then(@"Proposta deve ser enviada para Análise com Status Aguardando Analise")]
        public void ThenPropostaDeveSerEnviadaParaAnaliseComStatus()
        {
            
        }
    }
}
