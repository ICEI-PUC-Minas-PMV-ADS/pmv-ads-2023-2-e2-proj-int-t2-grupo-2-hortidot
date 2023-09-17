# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="02-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="04-Projeto de Interface.md"> Projeto de Interface</a>

Os requisitos para realização dos testes de software são:

- Aplicação publicada na Internet
- Navegador da Internet - Chrome, Firefox ou Edge

Os testes funcionais a serem realizados na aplicação são descritos a seguir.

|    Caso de Teste    |                                                                                                  **CT-01 – Ajustar preço**                                                                                                  |
| :-----------------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
| Requisito Associado |                                                           RF-01 - O sistema deve permitir que os fornecedores ajustem o preço para cada comprador correspondente.                                                           |
|  Objetivo do Teste  |                                                                              Verificar se os campos de preços são editáveis para o fornecedor.                                                                              |
|       Passos        | 1) Acessar o Navegador <br> 2) Informar o endereço da aplicação <br> 3) Inserir informações para o login <br> 4) Abrir a solicitação de cotação feita pelo comprador <br> 5) Inserir os preços correspondentes aos produtos |
|  Critério de Êxito  |                                                           O sistema deve permitir que o fornecedor altere os preços de seus produtos através de campos editáveis.                                                           |

|    Caso de Teste    |                                                                                                                               **CT-02 - Ajustar quantidades de produtos**                                                                                                                                |
| :-----------------: | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
| Requisito Associado |                                                                                                 RF-02 - O sistema deve permitir que o comprador e fornecedor ajustem a quantidade de itens solicitados.                                                                                                  |
|  Objetivo do Teste  |                                                                                                 Verificar se os campos de quantidades de produtos são editáveis para os usuários fornecedor e comprador.                                                                                                 |
|       Passos        | 1) Acessar o Navegador <br> 2) Informar o endereço da aplicação <br> 3) Inserir informações para o login <br> 4) Abrir uma nova cotação (comprador) <br> 5) Abrir a solicitação de cotação feita pelo comprador (fornecedor) <br> 6) Inserir as quantidades de itens desejadas ou disponíveis em estoque |
| Critérios de Êxito  |                                          O sistema deve permitir que o comprador possa colocar a quantidade de itens desejados na solicitação, e deve permitir que o fornecedor ajuste a quantidade de itens solicitados na cotação de acordo com seu estoque.                                           |

|    Caso de Teste    |                                                                                                                                  **CT-03 - Mensagem de aviso sobre a cotação**                                                                                                                                  |
| :-----------------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
| Requisito Associado |                                                                                                      RF-03 - O sistema deve enviar uma mensagem informando a abertura e fechamento da cotação solicitada.                                                                                                       |
|  Objetivo do Teste  |                                                                           Verificar se o sistema irá emitir corretamente uma mensagem de abertura e fechamento da cotação quando um botão específico com essas funções for disparado.                                                                           |
|       Passos        | 1) Acessar o Navegador <br> 2) Informar o endereço da aplicação <br> 3) Inserir informações para o login <br> 4) Abrir uma cotação com todas as informações necessárias (comprador) <br> 5) Abrir a solicitação de cotação feita pelo comprador (fornecedor) <br> 6) Ajustar informações <br> 7) Fechar cotação |
| Critérios de Êxito  |                                                                                 O sistema deve reconhecer a ação e enviar uma mensagem aos fornecedores e compradores, informando se a solicitação foi iniciada ou finalizada.                                                                                  |

|    Caso de Teste    |                                                       **CT-04 - Comunicação entre os usuários**                                                        |
| :-----------------: | :----------------------------------------------------------------------------------------------------------------------------------------------------: |
| Requisito Associado |                                 RF-04 - O sistema deve permitir um canal de comunicação entre fornecedor e comprador.                                  |
|  Objetivo do Teste  |          Verificar se o fornecedor e o comprador têm uma comunicação clara através dos canais de comunicação disponibilizados pela aplicação.          |
|       Passos        | 1) Acessar o Navegador <br> 2) Informar o endereço da aplicação <br> 3) Inserir informações para o login <br> 4) Clicar em “Chat” e iniciar a conversa |
| Critérios de Êxito  |                    Os usuários devem conseguir enviar e receber mensagens através de um canal de comunicação interno da aplicação.                     |

|   Casos de Teste    |                                                                                            **CT-05 - Revisão do pedido**                                                                                            |
| :-----------------: | :-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
| Requisito Associado |                                      RF-05 - O sistema deve permitir que o comprador e fornecedor possam fazer a revisão do pedido antes do fechamento e do envio da mensagem.                                      |
|  Objetivo do Teste  |                                                      Verificar se os usuários envolvidos na cotação conseguem fazer uma revisão do pedido antes do fechamento.                                                      |
|       Passos        | 1) Acessar o Navegador <br> 2) Informar o endereço da aplicação <br> 3) Inserir informações para o login <br> 4) Abrir a solicitação de cotação feita pelo comprador <br> 5) Verificar informações e fechar cotação |
| Critérios de Êxito  |                                                      Os usuários devem conseguir acessar a cotação em andamento para fazer uma revisão dos itens solicitados.                                                       |

|    Caso de Teste    |                                                                                              **CT-06 - Cadastro de produtos**                                                                                               |
| :-----------------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
| Requisito Associado |                                RF-06 - O sistema deve permitir o cadastro, edição e exclusão dos produtos de hortifruti contendo imagem, nome, código único do item e quantidade em estoque.                                |
|  Objetivo do teste  |                                                           Verificar se o cadastro dos produtos é feito de acordo com as especificações dos requisitos funcionais.                                                           |
|       Passos        | 1) Acessar o Navegador <br> 2) Informar o endereço da aplicação <br> 3) Inserir informações para o login <br> 4) No menu principal, clicar em “Cadastrar produto” <br> 5) Efetuar cadastro, alteração ou exclusão dos dados |
| Critérios de Êxito  |       O sistema deve permitir a criação de cadastros, a leitura dos dados desses cadastros, a atualização dos dados e, se necessário, a exclusão dessas informações. As informações devem ficar em um banco de dados.       |

|    Caso de Teste    |                                                                                         **CT-07 – Cadastro de usuário**                                                                                         |
| :-----------------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
| Requisito Associado |                                                 RF-07 - O sistema deve permitir que o fornecedor e comprador possam cadastrar, alterar e excluir seu cadastro.                                                  |
|  Objetivo do Teste  |                                                          Verificar se o cadastro de usuário funciona conforme especificado nos requisitos funcionais.                                                           |
|       Passos        |                   1) Acessar o Navegador <br> 2) Informar o endereço da aplicação <br> 3) Visualizar a página inicial <br> 4) Clicar em “Fazer cadastro” <br> 5) Realizar cadastro do usuário                   |
|  Critério de Êxito  | O sistema deve permitir a criação de cadastros, a leitura dos dados desses cadastros, a atualização dos dados e, se necessário, a exclusão dessas informações. As informações devem ficar em um banco de dados. |

|    Caso de Teste    |                                                                                       **CT-08 - Fechamento da cotação**                                                                                       |
| :-----------------: | :-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
| Requisito Associado |                                             RF-08 - O sistema deve permitir que o fornecedor feche o pedido e que o comprador finalize a cotação após a revisão.                                              |
|  Objetivo do Teste  |                                                         Verificar se os usuários conseguem executar a ação sem que ocorram erros durante o processo.                                                          |
|       Passos        | 1) Acessar o Navegador <br> 2) Informar o endereço da aplicação <br> 3) Inserir informações para o login <br> 4) Abrir a solicitação de cotação feita pelo comprador <br> 5) Clicar no botão “Fechar cotação” |
| Critérios de Êxito  |                                          O fornecedor deve conseguir fechar o pedido sem dificuldades, e o comprador deve conseguir finalizar o processo de cotação.                                          |
