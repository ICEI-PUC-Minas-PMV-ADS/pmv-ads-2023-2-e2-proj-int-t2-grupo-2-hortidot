# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Nesta seção são apresentadas as telas desenvolvidas para cada uma das funcionalidades do sistema. O respectivo endereço (URL) e outras orientações de acesso são são apresentadas na sequência.

### Tela login

Tela permite o usuário acessar sua conta com e-mail e senha.

<img src="/docs/img/tela-login.jpg" alt="">


#### Requisitos atendidos
* RF-09- O sistema deve permitir que o fornecedor e o comprador possam fazer login com e-mail e senha.

#### Artefatos da funcionalidade
* Login.cs<br>
* LoginController<br>
* DataContext.cs<br>
* Home.cshtml<br>
* Login.cshtml<br>
* Login.css

#### Instruções de acesso
1) Acessar o Navegador<br>
2) Informar o endereço da aplicação: (inserir URL)<br>
3) Inserir informações para o login<br>
4) Clique em "Entrar".<br>

### Tela Cadastro do Perfil

Tela permite o cadastro, edição e visualização de dados do usuário. A estrutura é um CRUD desenvolvido em C# e os dados ficam armazenados no banco de dados PostgreSQL. 

<img src="/docs/img/tela-cadastro-perfil.jpg" alt="">

#### Requisitos atendidos
* RF-05- O sistema deve permitir que o fornecedor e comprador possam cadastrar, alterar e excluir seu cadastro.

#### Artefatos da funcionalidade
* Usuario.cs<br>
* UsuariosController<br>
* DataContext.cs<br>
* CriarUsuario.cshtml<br>
* EditarUsuario.cshtml<br>
* Cadastro.css<br>

#### Instruções de acesso
1) Acessar o Navegador<br>
2) Informar o endereço da aplicação: (inserir URL)<br>
3) Inserir informações para o login<br>
4) Ainda na tela de login, clique em "Ainda não possui uma conta? Inscreva-se!"<br>

### Tela Editar Conta

Tela permite que o usuário edite e atualize suas informações pessoais e informações de sua empresa.

<img src="/" alt="">

#### Requisitos atendidos
* RF-05 - O sistema deve permitir que o fornecedor e o comprador possam cadastrar, alterar e excluir seu cadastro.

#### Artefatos da funcionalidade
* perfil.css<br>
* Usuario.cs<br>
* UsuariosControllers.cs<br>
* EditarUsuario.cshtml<br>
* DataContext.cs<br>

#### Instruções de acesso
1) Acessar o Navegador<br>
2) Informar o endereço da aplicação: (inserir URL)<br>
3) Inserir informações para o login<br>
4) Clique em "Entrar" para acessar a conta e a tela inicial.<br>
5) No menu lateral, clique em Editar Conta.<br>


### Tela Excluir Conta 

Tela que permite a exclusão dos dados de um usuário da base de dados. 

<img src="/docs/img/tela-excluir-perfil.jpg" alt="">

#### Requisitos atendidos
* RF-05 - O sistema deve permitir que o fornecedor e comprador possam cadastrar, alterar e excluir seu cadastro.

#### Artefatos da funcionalidade
* Usuario.cs<br>
* UsuariosController<br>
* DataContext.cs<br>
* DeletarConta.cshtml<br>

#### Instruções de acesso
1) Acessar o Navegador<br>
2) Informar o endereço da aplicação: (inserir URL)<br>
3) Inserir informações para o login<br>
4) Clique em "Entrar" para acessar a conta e a tela inicial.<br>
5) No menu lateral, clique em Excluir Conta.<br>

### Tela Págna Inicial 

Tela exibe os pedidos em andamento e últimos pedidos, e permite que o comprador abra um novo pedido.

<img src="/docs/img/tela-inicial.jpg" alt="">

#### Requisitos atendidos

RF-07 - O sistema deve permitir que o fornecedor e o comprador possam visualizar todos os pedidos.<br>
RF-10 - O sistema deve permitir a abertura de novos pedidos.<br>

#### Artefatos da funcionalidade
Em construção.

#### Instruções de acesso
1) Acessar o Navegador<br>
2) Informar o endereço da aplicação: (inserir URL)<br>
3) Inserir informações para o login<br>
4) Clique em "Entrar" para acessar a conta e a tela inicial.<br>

### Tela Pedidos

Tela mostra todos os pedidos feitos pelo comprador e os detalhes dos pedidos, além de permitir a abertura de novos pedidos. 

<img src="/docs/img/tela-pedidos.jpg" alt="">

#### Requisitos atendidos

RF-07 - O sistema deve permitir que o fornecedor e o comprador possam visualizar todos os pedidos.<br>
RF-10 - O sistema deve permitir a abertura de novos pedidos.<br>

#### Artefatos da funcionalidade
Em construção.

#### Instruções de acesso
1) Acessar o Navegador<br>
2) Informar o endereço da aplicação: (inserir URL)<br>
3) Inserir informações para o login<br>
4) Clique em "Entrar" para acessar a conta e a tela inicial.<br>
5) No menu lateral, clique em "Novo Pedido" para abrir uma nova cotação, ou clique em "Todos os pedidos" para visualizar uma lista de todos os pedidos.

### Tela Cadastro de Produtos

Tela permite o cadastro, edição, visualização e exclusão de dados de um produto. A estrutura é um CRUD desenvolvido em C# e os dados ficam armazenados no banco de dados PostgreSQL. 

<img src="/docs/img/tela-cadastro-produto.jpg" alt="">

#### Requisitos atendidos
* RF-04 - O sistema deve permitir o cadastro, edição e exclusão dos produtos de hortifruti contendo nome e código único do item.

#### Artefatos da funcionalidade 
* Produto.cs<br>
* ProdutosController.cs<br>
* Create.cshtml<br>
* produtos.css<br>

#### Instruções de acesso
1) Acessar o Navegador<br>
2) Informar o endereço da aplicação: (inserir URL)<br>
3) Inserir informações para o login<br>
4) Clique em "Entrar" para acessar a conta e a tela inicial.<br>
5) No menu lateral, clique em "Cadastrar Produto".

### Tela Produtos

Tela exibe aos usuários todos os produtos cadastrados pelo fornecedor.

<img src="/docs/img/tela-produtos.jpg" alt="">

#### Requisitos atendidos
* RF-08 - O sistema deve permitir que o fornecedor e o comprador possam visualizar todos os produtos cadastrados.

#### Artefatos da funcionalidade
* Produto.cs<br>
* ProdutosController.cs<br>
* Index.cshtml<br>
* Delete.cshtml<br>
* Details.cshtml<br>
* Edit.cshtml<br>
* Create.cshtml<br>
* produtos.css<br>

#### Instruções de acesso
1) Acessar o Navegador<br>
2) Informar o endereço da aplicação: (inserir URL)<br>
3) Inserir informações para o login<br>
4) Clique em "Entrar" para acessar a conta e a tela inicial.<br>
5) No menu lateral, clique em "Todos os produtos".

### Tela Nova Cotação (comprador)

Apresenta as opções de produtos e informações a serem incluidas em uma cotação para que seja enviada aos fornecedores, tais como código do produtos, imagem e nome dos produtos, juntamente com as quantidades desejadas.

<img src="/docs/img/tela-cotacao-comprador.jpg" alt="">

#### Requisitos atendidos
* RF-02 - O sistema deve permitir que o comprador e fornecedor ajustem a quantidade de itens solicitados.
* RF-06 - O sistema deve permitir que o fornecedor feche o pedido e que o comprador finalize a cotação após a revisão.
  
#### Artefatos da funcionalidade
Em construção.

### Tela Nova Cotação (fornecedor) 

Apresenta a cotação recebida para que seja editada e atualizada de acordo com os preços deste fornecedor. 

<img src="/docs/img/tela-cotacao-fornecedor.jpg" alt="">

#### Requisitos atendidos
* RF-01 - O sistema deve permitir que os fornecedores ajustem o preço para cada comprador correspondente.
* RF-02 - O sistema deve permitir que o comprador e fornecedor ajustem a quantidade de itens solicitados.
* RF-06 - O sistema deve permitir que o fornecedor feche o pedido e que o comprador finalize a cotação após a revisão.

#### Artefatos da funcionalidade
Em construção.

#### Estrutura de dados
Em construção.

### Tela Analisar Cotação

Apresenta as informações atualizadas pelos fornecedores para que sejam avaliadas para finalização do pedido.

<img src="/docs/img/tela-analisar-pedido.jpg" alt="">

#### Requisitos atendidos
* RF-03 - O sistema deve permitir que o comprador e fornecedor possam fazer a revisão do pedido antes do fechamento.

#### Artefatos da funcionalidade
Em construção.

#### Estrutura de dados
Em construção.

# Instruções de acesso

Não deixe de informar o link onde a aplicação estiver disponível para acesso (por exemplo: https://adota-pet.herokuapp.com/src/index.html).

Se houver usuário de teste, o login e a senha também deverão ser informados aqui (por exemplo: usuário - admin / senha - admin).

O link e o usuário/senha descritos acima são apenas exemplos de como tais informações deverão ser apresentadas.
