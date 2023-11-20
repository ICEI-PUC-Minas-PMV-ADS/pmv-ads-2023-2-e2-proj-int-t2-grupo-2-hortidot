# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="02-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="04-Projeto de Interface.md"> Projeto de Interface</a>

Os requisitos para realização dos testes de software são:

- Aplicação publicada na Internet
- Navegador da Internet - Chrome, Firefox ou Edge

Os testes funcionais a serem realizados na aplicação são descritos a seguir.

|    Caso de Teste    |                                                                                              **CT-01 - Cadastro de produtos**                                                                                               |
| :-----------------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
| Requisito Associado |                                RF-04 - O sistema deve permitir o cadastro, edição e exclusão dos produtos de hortifruti contendo nome e código único do item.                                |
|  Objetivo do teste  |                                                           Verificar se o cadastro dos produtos é feito de acordo com as especificações dos requisitos funcionais.                                                           |
|       Passos        | 1) Acessar o Navegador <br> 2) Informar o endereço da aplicação <br> 3) Inserir informações para o login <br> 4) No menu lateral, clicar em “Novo produto” <br> 5) Efetuar cadastro, alteração ou exclusão dos dados |
| Critérios de Êxito  |       O sistema deve permitir a criação de cadastros, a leitura dos dados desses cadastros, a atualização dos dados e, se necessário, a exclusão dessas informações. As informações devem ficar em um banco de dados.       |

|    Caso de Teste    |                                                                                         **CT-02– Cadastro de usuário**                                                                                         |
| :-----------------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
| Requisito Associado |                                                 RF-05 - O sistema deve permitir que o fornecedor e comprador possam cadastrar, alterar e excluir seu cadastro.                                                  |
|  Objetivo do Teste  |                                                          Verificar se o cadastro de usuário funciona conforme especificado nos requisitos funcionais.                                                           |
|       Passos        |                   1) Acessar o Navegador <br> 2) Informar o endereço da aplicação <br> 3) Na tela Login, clicar em "Ainda não tem uma conta? Inscreva-se!"<br> 5) Realizar cadastro do usuário                   |
|  Critério de Êxito  | O sistema deve permitir a criação de cadastros, a leitura dos dados desses cadastros, a atualização dos dados e, se necessário, a exclusão dessas informações. As informações devem ficar em um banco de dados. |

|    Caso de Teste    | **CT-03 - Login** |                                 
| :-----------------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
| Requisito Associado | RF-09 - O sistema deve permitir que o fornecedor e o comprador possam fazer login com e-mail e senha. |                              
|  Objetivo do Teste  | Verificar se o usuário consegue acessar sua conta com e-mail e senha. |
|       Passos        | 1) Acessar o Navegador <br> 2) Informar o endereço da aplicação <br> 3) Inserir informações para o login <br>  |
|  Critério de Êxito  |  O sistema deve permitir que o usuário acesse sua conta. |

| Caso de Teste | **CT-04 - Excluir conta de usuário** | 
| :-----------------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
| Requisito Associado | RF-05 - O sistema deve permitir que o fornecedor e o comprador possam cadastrar, alterar e excluir seu cadastro. | 
| Objetivo do Teste | Verificar se o sistema permite a exclusão da conta de um usuário. | 
| Passos | 1) Acessar o Navegador <br> 2) Informar o endereço da aplicação <br> 3) Inserir informações para o login <br> 4) No menu lateral, clicar em “Excluir Conta” <br> 5) Efetuar exclusão dos dados do usuário.<br>
| Critérios de Êxito | O sistema deve permitir a exclusão da conta. 

| Caso de Teste | **CT-05 - Editar conta de usuário** | 
| :-----------------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
| Requisito Associado | RF-05 - O sistema deve permitir que o fornecedor e o comprador possam cadastrar, alterar e excluir seu cadastro. | 
| Objetivo do Teste | Verificar se o sistema permite a edição da conta de um usuário. | 
| Passos | 1) Acessar o Navegador <br> 2) Informar o endereço da aplicação <br> 3) Inserir informações para o login <br> 4) No menu lateral, clicar em “Editar Conta” <br> 5) Efetuar a edição dos dados do usuário.<br>
| Critérios de Êxito | O sistema deve permitir a edição da conta. 

| Caso de Teste | **CT-06 - Edição de produto** | 
| :-----------------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
| Requisito Associado | RF-04 - O sistema deve permitir o cadastro, edição e exclusão dos produtos de hortifruti contendo nome e código único do item. | 
| Objetivo do Teste | Verificar se o sistema permite a edição de um produto cadastrado. | 
| Passos | 1) Acessar o Navegador <br> 2) Informar o endereço da aplicação <br> 3) Inserir informações para o login <br> 4) No menu lateral, clicar em “Todos os produto” <br> 5) Efetuar a edição do produto selecionado.<br>
| Critérios de Êxito | O sistema deve permitir a edição dos dados de um produto. 

