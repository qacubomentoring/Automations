Feature: Portal PTE

Scenario: 001 Gerar Proposta - Corretora
Given acesso ao Portal PTE
And Realizar o Login da Corretora
And Gerar uma Proposta
And Preencher Dados do produtor
And Preencher Dados da empresa
And Preencher Dados dos beneficiários
And Anexar Documentação
When clicar em Finalização proposta
Then Proposta deve ser enviada para Análise com Status Aguardando Análise
