# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="03-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="08-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Relatório com as evidências dos testes de software realizados no sistema pela equipe, baseado em um plano de testes pré-definido.
| Caso de Teste | CT-01 - Cadastro de produtos |
| :-----------------: | :-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
| Imagem | <img   src = "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/main/docs/img/CadastrodeProdutoCampoObrigatorio.jpeg"/> <img   src = "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/main/docs/img/CadastrandoProdutoBanana.jpeg"/> <img   src = "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/main/docs/img/ProdutoBananaCadastrado.jpeg"/> |
| Requisito Associado | RF-04- O sistema deve permitir o cadastro, edição e exclusão dos produtos de hortifruti contendo nome e código único do item |
| Avaliação | O sistema deve permitir o cadastro de um novo produto, com nome e código único. O nome do produto deve ser inserido no campo obrigatório, e o código próprio é gerado quando o produto é criado. ✅|

|    Caso de Teste    |                                                       CT-02– Cadastro de usuário                                                       |
| :-----------------: | :------------------------------------------------------------------------------------------------------------------------------------: |
|       Imagem        |                                                <img src = "/docs/img/criar-conta.png"/>                                                |
| Requisito Associado |             RF-05 - O sistema deve permitir que o fornecedor e comprador possam cadastrar, alterar e excluir seu cadastro              |
|      Avaliação      | Os campos obrigatórios devem ser preenchidos com os dados do usuário. O usuário deve clicar em "Criar Cadastro" para efetuar o a criação da conta com sucesso. ✅|

|    Caso de Teste    |                                                           CT-03 - Login                                                           |
| :-----------------: | :-------------------------------------------------------------------------------------------------------------------------------: |
|       Imagem        |                                               <img   src = "/docs/img/Login.png"/>                                                |
| Requisito Associado |               RF-09 - O sistema deve permitir que o fornecedor e o comprador possam fazer login com e-mail e senha                |
|      Avaliação      | O sistema deve permitir que o usuário faça login com os dados fornecidos no cadastro. Ao inserir o e-mail e senha corretamente, o login é efetuado com sucesso. ✅|

|    Caso de Teste    |                                                                                                 CT-04 - Excluir conta de usuário                                                                                                  |
| :-----------------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
|       Imagem        |                                        <img   src = "https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/main/docs/img/TesteExcluirConta.jpeg"/>                                        |
| Requisito Associado |                                                          RF-05 - O sistema deve permitir que o fornecedor e o comprador possam cadastrar, alterar e excluir seu cadastro                                                          |
|      Avaliação      | O sistema deve permitir que o usuário exclua sua conta. Deve-se clicar em "Excluir Conta" no menu lateral. Após confirmar a exclusão, o perfil é eliminado com sucesso. ✅|

|    Caso de Teste    |                                                                                       CT-05 - Editar conta de usuário                                                                                        |
| :-----------------: | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
|       Imagem        |                                                                                 <img   src = "/docs/img/Editar-Conta.png"/>                                                                                  |
| Requisito Associado |                                               RF-05 - O sistema deve permitir que o fornecedor e o comprador possam cadastrar, alterar e excluir seu cadastro                                                |
|      Avaliação      | Temos a possibilidade de editar perfil, trocar informações já cadastradas por novas atualizações, após efetuar as devidas modificações clicar em salvar alterações. Edição da conta realizada com sucesso ✅ |

|    Caso de Teste    |                                                                                       CT-06 - Edição de produto                                                                                       |
| :-----------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
|       Imagem        |                                                                             <img   src = "/docs/img/Editar-produto.png"/>                                                                             |
| Requisito Associado |                                     RF-04 - O sistema deve permitir o cadastro, edição e exclusão dos produtos de hortifruti contendo nome e código único do item                                     |
|      Avaliação      | Para realizar a edição do produto, é preciso clicar em todos os produtos, ir no lápis de edição do produto que desejado, modificar o que deseja e salvar. Edição de produto realizado com sucesso. ✅ |

|    Caso de Teste    |                                                                                                                                                     CT-07 - Excluir produto                                                                                                                                                     |
| :-----------------: | :-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
|       Imagem        |                                                                                                                                          <img   src = "/docs/img/Apagar-produto.png"/>                                                                                                                                          |
| Requisito Associado |                                                                                                  RF-04 - O sistema deve permitir o cadastro, edição e exclusão dos produtos de hortifruti contendo nome e código único do item                                                                                                  |
|      Avaliação      | Indo na lista de todos os produtos e possível excluir um produto devidamente cadastrado, indo no item e clicando na representação de excluir, assim, aparecerá uma mensagem perguntando você tem certeza de que deseja apagar este produto, para continuar e só clicar em apagar. Exclusão de produto realizado com sucesso. ✅ |

|    Caso de Teste    |                                                                                                            CT-08 - Criação de Pedido                                                                                                             |
| :-----------------: | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
|       Imagem        |                                                                                                   <img   src = "/docs/img/Criar-pedido.png"/>                                                                                                    |
| Requisito Associado |                                                                                           RF-10 - O sistema deve permitir a abertura de novos pedidos.                                                                                           |
|      Avaliação      | Para criar um pedido é necessário clicar na aba novo pedido e ir no (+) para adicionar os produtos que queira incluir na lista do novo pedido, assim, como é possível ir no (-) e retirar o produto. Criação do pedido realizado com sucesso. ✅ |

|    Caso de Teste    |                                                                                                      CT-09 - Edição de Pedido                                                                                                       |
| :-----------------: | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
|       Imagem        |                                                                      <img   src = "/docs/img/Editar-pedido.png"/> <img   src = "/docs/img/EditarPedido.jpg"/>                                                                       |
| Requisito Associado |                                                         RF-03 O sistema deve permitir que o comprador e o fornecedor possam fazer a revisão do pedido antes do fechamento.                                                          |
|      Avaliação      | Primeiro teste, ao clicar em salvar alterações o sistema não salvou o status correto no banco de dados. ❌ No segundo teste, após a correção do erro, ao salvar as alterações o novo status do pedido foi realizado com sucesso. ✅ |

|    Caso de Teste    |                                                                                                                         CT-10 - Exclusão de Pedido                                                                                                                          |
| :-----------------: | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
|       Imagem        |                                                                                                                <img   src = "/docs/img/Apagar-pedido.png"/>                                                                                                                 |
| Requisito Associado |                                                                             RF-03 O sistema deve permitir que o comprador e o fornecedor possam fazer a revisão do pedido antes do fechamento.                                                                              |
|      Avaliação      | Podemos realizar a exclusão do pedido já criado, clicando no pedido e clicando na representação de excluir, onde exibirá a pergunta você tem certeza que deseja apagar este pedido, assim, sendo permitido apagar ou cancelar. Exclusão do pedido realizado com sucesso. ✅ |

# Relatório de Testes de Software
## Execução dos testes
No dia 19 de novembro de 2023, foram realizados os primeiros testes para o registro de teste de software da aplicação HortiDot, com objetivo de validar o desenvolvimento da aplicação e suas funcionalidades.

Iniciamos nossos testes com o cadastro de produtos, que atende ao requisito 04, em que o sistema deve permitir o cadastro, edição e exclusão dos produtos de hortifruti contendo nome e código único do item.  O sistema executou com excelência o cadastro de novos produtos, permitindo que o comprador e o fornecedor efetuem o cadastro. O segundo teste foi voltado para o cadastro de usuários, visando atender ao requisito 05, que deve permitir que o fornecedor e comprador possam cadastrar, alterar e excluir seu cadastro. Só é possível efetuar o cadastro de um usuário com o preenchimento de todos os campos obrigatórios, que inclui os dados pessoais do usuário e os dados da empresa. O usuário deve informar se é um comprador ou um fornecedor. É possível alterar e excluir os dados do usuário.

O terceiro teste foi referente à tela de login, atendendo ao requisito 09, que deve permitir que o fornecedor e o comprador possam fazer login com e-mail e senha. O usuário deve criar uma conta, e, ao clicar em "Criar Cadastro", deve ser redirecionado à tela de login. Na tela de login, o usuário deve inserir o e-mail e senha cadastrados. O quarto teste foi referente à exclusão da conta de um usuário, associado ao requisito 05, em que o sistema deve permitir que o fornecedor e o comprador possam cadastrar, alterar e excluir seu cadastro. O sistema permite que um usuário exclua sua conta e seus dados cadastrados no sistema. O usuário pode criar uma nova conta posteriormente.
Seguimos os testes com editar conta de um usuário, atendendo ao requisito 05, o sistema deve permitir que o fornecedor e o comprador possam cadastrar, alterar e excluir seu cadastro. O usuário pode alterar seus dados cadastrais, como nome, e-mail, CPF, telefone, nome da empresa, CNPJ, endereço, senha e tipo de usuário. Os testes de número 06 e 07 foram voltados à edição e exclusão de produtos, ambos estão ligados ao requisito 04, em que o sistema deve permitir o cadastro, edição e exclusão dos produtos de hortifruti contendo nome e código único do item. É possível realizar a edição e a exclusão de produtos com sucesso.

O oitavo teste foi uma tentativa de a criar um novo pedido, voltado para o requisito 10, em que o sistema deve permitir a abertura de novos pedidos. A funcionalidade não teve sucesso ao ser executada. O nono teste foi referente à edição de um pedido, voltado ao requisito 03, o sistema deve permitir que o comprador e o fornecedor possam fazer a revisão do pedido antes do fechamento. Inicialmente, a funcionalidade não teve sucesso, porém foi corrigida, como mostrado na segunda imagem do teste. O décimo registro, também voltado ao requisito 03, mencionado anteriormente, podemos realizar a exclusão do pedido já criado, clicando no pedido e em apagar, permitido apagar ou cancelar.

## Conclusão
Foram 11 casos de teste executados, sendo o primeiro teste referente ao CT-09 - Edição de Pedido o único que apresentou inconsistência. Após o ajuste no código, o teste foi realizado novamente apresentando sucesso.

Alguns requisitos propostos ao longo do desenvolvimento deste projeto foram despriorizados ou não foram executados como gostaríamos, entre eles podemos citar: 
- 01- O sistema deve permitir que os fornecedores ajustem o preço para cada comprador correspondente,
- 02 - O sistema deve permitir que o comprador e o fornecedor ajustem a quantidade de itens solicitados,
- 06 - O sistema deve permitir que o fornecedor feche o pedido e que o comprador finalize a cotação após a revisão.

A aplicação precisa de algumas melhorias e ajustes em funções, e estamos buscando aperfeiçoar. Porém, o que criamos até aqui, mostra que a equipe empenhou-se na elaboração e execução deste projeto.
