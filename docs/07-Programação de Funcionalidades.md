# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Nesta seção são apresentadas as telas desenvolvidas para cada uma das funcionalidades do sistema. Os dados da aplicação ficam armazenados no banco de dados PostgreSQL.

### Artefatos compartilhados em toda aplicação

- \_layout.cshtml
- site.css
- DataContext.cs
- favicon.ico
- Program.cs

### Tela login

Tela permite o usuário acessar sua conta com e-mail e senha.

<img src="/docs/img/Login.png" alt="tela de login">

#### Requisitos atendidos

- RF-09 - O sistema deve permitir que o fornecedor e o comprador possam fazer login com e-mail e senha.

#### Artefatos da funcionalidade

- Login.cs
- LoginController.cs
- Login.cshtml
- login.css
- login-bg.jpg

#### Instruções de acesso

1. Acessar o Navegador
2. Informar o endereço da aplicação: http://hortidot.azurewebsites.net/
3. Inserir informações para o login
4. Clique em "Entrar"

### Tela Cadastro do Perfil

Tela permite o cadastro, edição e visualização de dados do usuário.

<img src="/docs/img/criar-conta.png" alt="cadastro de usuário">

#### Requisitos atendidos

- RF-05 - O sistema deve permitir que o fornecedor e o comprador possam cadastrar, alterar e excluir seu cadastro.

#### Artefatos da funcionalidade

- Usuario.cs
- UsuariosController.cs
- CriarUsuario.cshtml
- Cadastro.css

#### Instruções de acesso

1. Acessar o Navegador
2. Informar o endereço da aplicação: http://hortidot.azurewebsites.net/
3. Na tela de login, clique em "Ainda não possui uma conta? Inscreva-se!"

### Tela Editar Conta

Tela permite que o usuário edite e atualize suas informações pessoais e informações de sua empresa.

<img src="/docs/img/" alt="editar conta">

#### Requisitos atendidos

- RF-05 - O sistema deve permitir que o fornecedor e o comprador possam cadastrar, alterar e excluir seu cadastro.

#### Artefatos da funcionalidade

- Usuario.cs
- UsuariosController.cs
- EditarUsuario.cshtml
- Cadastro.css

#### Instruções de acesso

1. Acessar o Navegador
2. Informar o endereço da aplicação: http://hortidot.azurewebsites.net/
3. Inserir informações para o login
4. Clique em "Entrar" para acessar a conta e a tela inicial.
5. No menu lateral, clique em Editar Conta

### Tela Excluir Conta

Tela que permite a exclusão dos dados de um usuário da base de dados.

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/a3b473035d9cceebc7e09472f88a62faf1ad2671/docs/img/DeletarConta.jpeg" alt="apagar conta">

#### Requisitos atendidos

- RF-05 - O sistema deve permitir que o fornecedor e comprador possam cadastrar, alterar e excluir seu cadastro.

#### Artefatos da funcionalidade

- Usuario.cs
- UsuariosController.cs
- DeletarConta.cshtml

#### Instruções de acesso

1. Acessar o Navegador
2. Informar o endereço da aplicação: http://hortidot.azurewebsites.net/<br>
3. Inserir informações para o login<br>
4. Clique em "Entrar" para acessar a conta e a tela inicial.<br>
5. No menu lateral, clique em Excluir Conta.<br>

### Tela Página Inicial

Tela exibe os pedidos em andamento e últimos pedidos, e permite que o comprador abra um novo pedido.

<img src="/docs/img/tela-inicial.jpg" alt="">
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/6179d47a332cac9fe113aae1e36857ca29a49f42/docs/img/Tela%20Inicial%20sem%20pedidos.jpeg" alt="">

#### Requisitos atendidos

RF-07 - O sistema deve permitir que o fornecedor e o comprador possam visualizar todos os pedidos.<br>
RF-10 - O sistema deve permitir a abertura de novos pedidos.<br>

#### Artefatos da funcionalidade

- Login.cs
- LoginController
- Home.cshtml

#### Instruções de acesso

1. Acessar o Navegador<br>
2. Informar o endereço da aplicação: http://hortidot.azurewebsites.net/<br>
3. Inserir informações para o login<br>
4. Clique em "Entrar" para acessar a conta e a tela inicial.<br>

### Tela Pedidos

Tela mostra todos os pedidos feitos pelo comprador e os detalhes dos pedidos, além de permitir a abertura de novos pedidos.

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/30b714e51a80f7178e06ed38fbbdfdb28c45744f/docs/img/Criar%20Pedido%20com%20itens.jpeg" alt="">
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/64a76def1ce340664fe102e0ffc26da853a3a608/docs/img/TelaPedidos.jpeg" alt="">

#### Requisitos atendidos

RF-07 - O sistema deve permitir que o fornecedor e o comprador possam visualizar todos os pedidos.<br>
RF-10 - O sistema deve permitir a abertura de novos pedidos.<br>

#### Artefatos da funcionalidade

- Pedido.cs
- PedidosController.cs
- Create.cshtml
- Delete.cshtml
- Details.cshtml
- Edit.cshtml
- Index.cshtml

#### Instruções de acesso

1. Acessar o Navegador<br>
2. Informar o endereço da aplicação: http://hortidot.azurewebsites.net/<br>
3. Inserir informações para o login<br>
4. Clique em "Entrar" para acessar a conta e a tela inicial.<br>
5. No menu lateral, clique em "Novo Pedido" para abrir uma nova cotação, ou clique em "Todos os pedidos" para visualizar uma lista de todos os pedidos.

### Tela Cadastro de Produtos

Tela permite o cadastro, edição, visualização e exclusão de dados de um produto. A estrutura é um CRUD desenvolvido em C# e os dados ficam armazenados no banco de dados PostgreSQL.

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/468ce0f24fe5525c923845b05864558bbb6d746f/docs/img/CadastrarProduto.jpeg" alt="">

#### Requisitos atendidos

- RF-04 - O sistema deve permitir o cadastro, edição e exclusão dos produtos de hortifruti contendo nome e código único do item.

#### Artefatos da funcionalidade

- Produto.cs<br>
- ProdutosController.cs<br>
- Create.cshtml<br>
- produtos.css<br>

#### Instruções de acesso

1. Acessar o Navegador<br>
2. Informar o endereço da aplicação: http://hortidot.azurewebsites.net/<br>
3. Inserir informações para o login<br>
4. Clique em "Entrar" para acessar a conta e a tela inicial.<br>
5. No menu lateral, clique em "Cadastrar Produto".

### Tela Produtos

Tela exibe aos usuários todos os produtos cadastrados pelo fornecedor.

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/468ce0f24fe5525c923845b05864558bbb6d746f/docs/img/TodososProdutos.jpeg" alt="">

#### Requisitos atendidos

- RF-08 - O sistema deve permitir que o fornecedor e o comprador possam visualizar todos os produtos cadastrados.

#### Artefatos da funcionalidade

- Produto.cs<br>
- ProdutosController.cs<br>
- Index.cshtml<br>
- Delete.cshtml<br>
- Details.cshtml<br>
- Edit.cshtml<br>
- Create.cshtml<br>
- produtos.css<br>

#### Instruções de acesso

1. Acessar o Navegador<br>
2. Informar o endereço da aplicação: http://hortidot.azurewebsites.net/<br>
3. Inserir informações para o login<br>
4. Clique em "Entrar" para acessar a conta e a tela inicial.<br>
5. No menu lateral, clique em "Todos os produtos".

### Tela Nova Cotação (comprador)

Apresenta as opções de produtos e informações a serem incluidas em uma cotação para que seja enviada aos fornecedores, tais como código do produtos, imagem e nome dos produtos, juntamente com as quantidades desejadas.

<img src="/docs/img/tela-cotacao-comprador.jpg" alt="">

#### Requisitos atendidos

- RF-02 - O sistema deve permitir que o comprador e fornecedor ajustem a quantidade de itens solicitados.
- RF-06 - O sistema deve permitir que o fornecedor feche o pedido e que o comprador finalize a cotação após a revisão.

#### Artefatos da funcionalidade

Em construção.

### Tela Nova Cotação (fornecedor)

Apresenta a cotação recebida para que seja editada e atualizada de acordo com os preços deste fornecedor.

<img src="/docs/img/tela-cotacao-fornecedor.jpg" alt="">

#### Requisitos atendidos

- RF-01 - O sistema deve permitir que os fornecedores ajustem o preço para cada comprador correspondente.
- RF-02 - O sistema deve permitir que o comprador e fornecedor ajustem a quantidade de itens solicitados.
- RF-06 - O sistema deve permitir que o fornecedor feche o pedido e que o comprador finalize a cotação após a revisão.

#### Artefatos da funcionalidade

Em construção.

#### Estrutura de dados

Em construção.

### Tela Analisar Cotação

Apresenta as informações atualizadas pelos fornecedores para que sejam avaliadas para finalização do pedido.

<img src="/docs/img/tela-analisar-pedido.jpg" alt="">

#### Requisitos atendidos

- RF-03 - O sistema deve permitir que o comprador e fornecedor possam fazer a revisão do pedido antes do fechamento.

#### Artefatos da funcionalidade

Em construção.

#### Estrutura de dados

Em construção.

# Instruções de acesso

Não deixe de informar o link onde a aplicação estiver disponível para acesso (por exemplo: https://adota-pet.herokuapp.com/src/index.html).

Se houver usuário de teste, o login e a senha também deverão ser informados aqui (por exemplo: usuário - admin / senha - admin).

O link e o usuário/senha descritos acima são apenas exemplos de como tais informações deverão ser apresentadas.
