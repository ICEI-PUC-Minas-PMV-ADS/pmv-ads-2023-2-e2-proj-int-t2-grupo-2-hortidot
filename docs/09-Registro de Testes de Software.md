# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="03-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="08-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Relatório com as evidências dos testes de software realizados no sistema pela equipe, baseado em um plano de testes pré-definido.
| Caso de Teste | CT-01 - Cadastro de produtos |
| :-----------------: | :-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
| Imagem | <img   src = "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/main/docs/img/CadastrarProduto.jpeg"/> |
| Requisito Associado | RF-04- O sistema deve permitir o cadastro, edição e exclusão dos produtos de hortifruti contendo nome e código único do item |
| Avaliação | ✅ Cadastro realizado com êxito |

|    Caso de Teste    |                                          CT-02– Cadastro de usuário                                           |
| :-----------------: | :-----------------------------------------------------------------------------------------------------------: |
|       Imagem        |                                   <img src = "/docs/img/criar-conta.png"/>                                    |
| Requisito Associado | RF-05 - O sistema deve permitir que o fornecedor e comprador possam cadastrar, alterar e excluir seu cadastro |
|      Avaliação      |                                       ✅ Cadastro realizado com sucesso                                       |

|    Caso de Teste    |                                            CT-03 - Login                                             |
| :-----------------: | :--------------------------------------------------------------------------------------------------: |
|       Imagem        |                                 <img   src = "/docs/img/Login.png"/>                                 |
| Requisito Associado | RF-09 - O sistema deve permitir que o fornecedor e o comprador possam fazer login com e-mail e senha |
|      Avaliação      |                                     ✅ Login realizado com êxito                                     |

|    Caso de Teste    |                                                          CT-04 - Excluir conta de usuário                                                           |
| :-----------------: | :-------------------------------------------------------------------------------------------------------------------------------------------------: |
|       Imagem        | <img   src = "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/main/docs/img/TesteExcluirConta.jpeg"/> |
| Requisito Associado |                   RF-05 - O sistema deve permitir que o fornecedor e o comprador possam cadastrar, alterar e excluir seu cadastro                   |
|      Avaliação      |                                              ✅ Exclusão de usuário realizado com sucesso                                            |

|    Caso de Teste    |                                         CT-05 - Editar conta de usuário                                         |
| :-----------------: | :-------------------------------------------------------------------------------------------------------------: |
|       Imagem        |                                   <img   src = "/docs/img/Editar-Conta.png"/>                                   |
| Requisito Associado | RF-05 - O sistema deve permitir que o fornecedor e o comprador possam cadastrar, alterar e excluir seu cadastro |
|      Avaliação      |                                    ✅ Edição da conta realizada com sucesso                                     |

|    Caso de Teste    |                                                   CT-06 - Edição de produto                                                   |
| :-----------------: | :---------------------------------------------------------------------------------------------------------------------------: |
|       Imagem        |                                         <img   src = "/docs/img/Editar-produto.png"/>                                         |
| Requisito Associado | RF-04 - O sistema deve permitir o cadastro, edição e exclusão dos produtos de hortifruti contendo nome e código único do item |
|      Avaliação      |                                          ✅ Edição de produto realizado com sucesso                                           |

|    Caso de Teste    |                                                    CT-07 - Excluir produto                                                    |
| :-----------------: | :---------------------------------------------------------------------------------------------------------------------------: |
|       Imagem        |                                         <img   src = "/docs/img/Apagar-produto.png"/>                                         |
| Requisito Associado | RF-04 - O sistema deve permitir o cadastro, edição e exclusão dos produtos de hortifruti contendo nome e código único do item |
|      Avaliação      |                                         ✅ Exclusão de produto realizado com sucesso                                          |

|    Caso de Teste    |                  CT-08 - Criação de Pedido                   |
| :-----------------: | :----------------------------------------------------------: |
|       Imagem        |         <img   src = "/docs/img/Criar-pedido.png"/>          |
| Requisito Associado | RF-10 - O sistema deve permitir a abertura de novos pedidos. |
|      Avaliação      |          ✅ Criação do pedido realizado com sucesso          |

|    Caso de Teste    |                                      CT-09 - Edição de Pedido                                      |
| :-----------------: | :------------------------------------------------------------------------------------------------: |
|       Imagem        |                            <img   src = "/docs/img/Editar-pedido.png"/>                            |
| Requisito Associado | RF-03 O sistema deve permitir que o comprador e o fornecedor possam fazer a revisão do pedido antes do fechamento. |
|      Avaliação      |                         ❌ Edição do pedido não foi realizado com sucesso                          |

|    Caso de Teste    |                                     CT-10 - Exclusão de Pedido                                     |
| :-----------------: | :------------------------------------------------------------------------------------------------: |
|       Imagem        |                            <img   src = "/docs/img/Apagar-pedido.png"/>                            |
| Requisito Associado | RF-03 O sistema deve permitir que o comprador e o fornecedor possam fazer a revisão do pedido antes do fechamento. |
|      Avaliação      |                            ✅ Exclusão do pedido realizado com sucesso                             |

# Relatório de Testes de Software

No dia 19 de novembro de 2023, foi realizado o registro de teste de software da aplicação HortiDot, com objetivo de registrar as funcionalidades da aplicação.

Iniciamos nossos testes com o cadastro de produto, que atende ao requisito 04, em que o sistema deve permitir o cadastro, edição e exclusão dos produtos de hortifruti contendo nome e código único do item, o sistema executou com excelência a criação de cadastros, sendo possível incluir os produtos, e ver todos os produtos cadastrados. Nosso segundo teste foi voltado para cadastro de usuário, visando atender ao requisito 05, o sistema deve permitir que o fornecedor e comprador possam cadastrar, alterar e excluir seu cadastro, só é possível efetuar o cadastro de usuário com o preenchimento dos campos obrigatórios, com dados pessoais e dados da empresa, ao final indicando o tipo de usuário fornecedor ou comprador, possibilitando também alterar dados já cadastrados, funcionalidade executado com sucesso.

Em seguida foi a vez de testar o Login, atendendo ao requisito 09, o sistema deve permitir que o fornecedor e o comprador possam fazer login com e-mail e senha, após a realização do cadastro de usuário, nos possibilita realizar o login com êxito. No quarto teste excluir conta de usuário, associado ao requisito 05, o sistema deve permitir que o fornecedor e o comprador possam cadastrar, alterar e excluir seu cadastro, ou seja, o próprio usuário excluir sua conta, na opção sim quero excluir, e todos os seus dados serão apagados. 

Seguimos os testes com editar conta de usuário, atendendo ao requisito 05, o sistema deve permitir que o fornecedor e o comprador possam cadastrar, alterar e excluir seu cadastro permitindo alterar, nome completo, e-mail, cpf, telefone, nome da empresa, CNPJ, endereço, senha e tipo de usuário, e clicando em salvar alterações. No sexto teste realizamos a edição de produto e no sétimo excluir produtos, ambos estão ligados ao requisito 04, em que o sistema deve permitir o cadastro, edição e exclusão dos produtos de hortifruti contendo nome e código único do item, ambos funcionando corretamente, editando, podendo trocar por outro produto ou corrigir já existente e salvar a edição, e excluindo clicando em apagar produto.

No oitavo teste realizamos a criação de pedido, que nos possibilita criar um pedido, e está adicionando os itens desejados ao pedido, voltado para o requisito 10, o sistema deve permitir a abertura de novos pedidos, função executando com excelência, no novo teste edição de pedido, voltado ao requisito 03, o sistema deve permitir que o comprador e o fornecedor possam fazer a revisão do pedido antes do fechamento, infelizmente esta não está funcionando com sucesso até o presente momento da construção deste relatório. O décimo registro de teste, também voltado ao requisito 03, mencionado anteriormente, podemos realizar a exclusão do pedido já criado, clicando no pedido e em apagar, funcionando de maneira correta.

Demos o melhor de nós nesta aplicação, é notável que precisa de algumas melhorias, e estamos buscamos aperfeiçoar nosso sistema. 
