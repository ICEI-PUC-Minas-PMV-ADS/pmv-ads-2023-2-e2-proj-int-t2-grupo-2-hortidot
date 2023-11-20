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

### Tela Cadastrar conta

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

<img src="/docs/img/Editar-Conta.png" alt="editar conta">

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

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/6179d47a332cac9fe113aae1e36857ca29a49f42/docs/img/Tela%20Inicial%20sem%20pedidos.jpeg" alt="">
Página inicial sem pedidos

<img src="/docs/img/Página-inicial-com-pedidos.png" alt="">
Página inicial com pedidos

#### Requisitos atendidos

RF-07 - O sistema deve permitir que o fornecedor e o comprador possam visualizar todos os pedidos.<br>
RF-10 - O sistema deve permitir a abertura de novos pedidos.<br>

#### Artefatos da funcionalidade

- ListaPedidos.cs
- Pedido.cs
- LoginController.cs
- Home.cshtml

#### Instruções de acesso

1. Acessar o Navegador
2. Informar o endereço da aplicação: http://hortidot.azurewebsites.net/
3. Inserir informações para o login
4. Clique em "Entrar" para acessar a conta e a tela inicial

### Tela Produtos

Tela que exibe aos usuários todos os produtos cadastrados.

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/468ce0f24fe5525c923845b05864558bbb6d746f/docs/img/TodososProdutos.jpeg" alt="">

#### Requisitos atendidos

- RF-08 - O sistema deve permitir que o fornecedor e o comprador possam visualizar todos os produtos cadastrados.

#### Artefatos da funcionalidade

- Produto.cs
- ProdutosController.cs
- Index.cshtml

#### Instruções de acesso

1. Acessar o Navegador
2. Informar o endereço da aplicação: http://hortidot.azurewebsites.net/
3. Inserir informações para o login
4. Clique em "Entrar" para acessar a conta e a tela inicial.
5. No menu lateral, clique em "Todos os produtos".

### Tela Cadastro de Produto

Tela que permite o cadastro de um produto.

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/468ce0f24fe5525c923845b05864558bbb6d746f/docs/img/CadastrarProduto.jpeg" alt="">

#### Requisitos atendidos

- RF-04 - O sistema deve permitir o cadastro, edição e exclusão dos produtos de hortifruti contendo nome e código único do item.

#### Artefatos da funcionalidade

- Produto.cs
- ProdutosController.cs
- Create.cshtml

#### Instruções de acesso

1. Acessar o Navegador
2. Informar o endereço da aplicação: http://hortidot.azurewebsites.net/
3. Inserir informações para o login
4. Clique em "Entrar" para acessar a conta e a tela inicial.
5. No menu lateral, clique em "Novo Produto".

### Tela Edição de Produto

Tela que permite a edição de um produto.

<img src="/docs/img/Editar-produto.png" alt="">

#### Requisitos atendidos

- RF-04 - O sistema deve permitir o cadastro, edição e exclusão dos produtos de hortifruti contendo nome e código único do item.

#### Artefatos da funcionalidade

- Produto.cs
- ProdutosController.cs
- Edit.cshtml

#### Instruções de acesso

1. Acessar o Navegador
2. Informar o endereço da aplicação: http://hortidot.azurewebsites.net/
3. Inserir informações para o login
4. Clique em "Entrar" para acessar a conta e a tela inicial.
5. No menu lateral, clique em "Todos os produtos".
6. Clique no ícone de lápis do produto que deseja editar.

### Tela Exclusão do Produto

Tela que permite a exclusão de um produto.

<img src="/docs/img/Apagar-produto.png" alt="">

#### Requisitos atendidos

- RF-04 - O sistema deve permitir o cadastro, edição e exclusão dos produtos de hortifruti contendo nome e código único do item.

#### Artefatos da funcionalidade

- Produto.cs
- ProdutosController.cs
- Delete.cshtml

#### Instruções de acesso

1. Acessar o Navegador
2. Informar o endereço da aplicação: http://hortidot.azurewebsites.net/
3. Inserir informações para o login
4. Clique em "Entrar" para acessar a conta e a tela inicial.
5. No menu lateral, clique em "Todos os produtos".
6. Clique no ícone de lixeira do produto que deseja excluir.

### Tela Detalhes do Produto

Tela que permite visualizar um produto.

<img src="/docs/img/Detalhes-produto.png" alt="">

#### Requisitos atendidos

- RF-04 - O sistema deve permitir o cadastro, edição e exclusão dos produtos de hortifruti contendo nome e código único do item.

#### Artefatos da funcionalidade

- Produto.cs
- ProdutosController.cs
- Details.cshtml

#### Instruções de acesso

1. Acessar o Navegador
2. Informar o endereço da aplicação: http://hortidot.azurewebsites.net/
3. Inserir informações para o login
4. Clique em "Entrar" para acessar a conta e a tela inicial.
5. No menu lateral, clique em "Todos os produtos".
6. Clique no ícone do olho do produto que deseja ver.

### Tela Pedidos

Tela mostra todos os pedidos feitos pelo usuário, além de permitir a abertura de novos pedidos.

<img src="/docs/img/TelaPedidos.jpeg" alt="">

#### Requisitos atendidos

RF-07 - O sistema deve permitir que o fornecedor e o comprador possam visualizar todos os pedidos.

#### Artefatos da funcionalidade

- Pedido.cs
- PedidosController.cs
- Index.cshtml

#### Instruções de acesso

1. Acessar o Navegador
2. Informar o endereço da aplicação: http://hortidot.azurewebsites.net/
3. Inserir informações para o login
4. Clique em "Entrar" para acessar a conta e a tela inicial.
5. No menu lateral, clique em "Todos os pedidos".

### Tela criar pedido

Tela que apresenta os itens para serem adicionados a lista do pedido, contendo código e nome.

<img src="/docs/img/Criar-pedido.png" alt="">

#### Requisitos atendidos

RF-10 - O sistema deve permitir a abertura de novos pedidos.

#### Artefatos da funcionalidade

- Pedido.cs
- PedidosController.cs
- Create.cshtml

#### Instruções de acesso

1. Acessar o Navegador
2. Informar o endereço da aplicação: http://hortidot.azurewebsites.net/
3. Inserir informações para o login
4. Clique em "Entrar" para acessar a conta e a tela inicial.
5. No menu lateral, clique em "Novo pedido".

### Tela editar pedido

Apresenta um select onde você pode alterar o status do pedido.

<img src="/docs/img/Editar-pedido.png" alt="">

#### Requisitos atendidos

RF-07 - O sistema deve permitir que o fornecedor e o comprador possam visualizar todos os pedidos.

#### Artefatos da funcionalidade

- Pedido.cs
- PedidosController.cs
- Edit.cshtml

#### Instruções de acesso

1. Acessar o Navegador
2. Informar o endereço da aplicação: http://hortidot.azurewebsites.net/
3. Inserir informações para o login
4. Clique em "Entrar" para acessar a conta e a tela inicial.
5. No menu lateral, clique em "Todos os pedidos".
6. Clique no ícone do lápis do pedido que deseja editar.

### Tela excluir pedido

Apresenta uma mensagem para confirmação da esclusão do pedido.

<img src="/docs/img/Apagar-pedido.png" alt="">

#### Requisitos atendidos

RF-07 - O sistema deve permitir que o fornecedor e o comprador possam visualizar todos os pedidos.

#### Artefatos da funcionalidade

- Pedido.cs
- PedidosController.cs
- Delete.cshtml

#### Instruções de acesso

1. Acessar o Navegador
2. Informar o endereço da aplicação: http://hortidot.azurewebsites.net/
3. Inserir informações para o login
4. Clique em "Entrar" para acessar a conta e a tela inicial.
5. No menu lateral, clique em "Todos os pedidos".
6. Clique no ícone da lixeira do pedido que deseja excluir.

### Tela detalhes do pedido

Apresenta os detalhes do pedido selecionado, incluindo id, código do comprador, lista de itens do pedido, data de abertura e status.

<img src="/docs/img/Detalhes-pedido.png" alt="">

#### Requisitos atendidos

RF-07 - O sistema deve permitir que o fornecedor e o comprador possam visualizar todos os pedidos.

#### Artefatos da funcionalidade

- Pedido.cs
- PedidosController.cs
- Details.cshtml

#### Instruções de acesso

1. Acessar o Navegador
2. Informar o endereço da aplicação: http://hortidot.azurewebsites.net/
3. Inserir informações para o login
4. Clique em "Entrar" para acessar a conta e a tela inicial.
5. No menu lateral, clique em "Todos os pedidos".
6. Clique no ícone do olho do pedido que deseja ver.
