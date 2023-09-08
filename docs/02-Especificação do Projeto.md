# Especificações do Projeto
<span style="color:red">Pré-requisitos: <a href="01-Documentação de Contexto.md"> Documentação de Contexto</a></span>

A precisa delimitação do problema e os aspectos mais importantes a serem abordados nesse projeto foram estabelecidos com a observação dos usuários em seus ambientes cotidianos e a realização de entrevistas. As informações obtidas foram então organizadas em personas e histórias de usuários.

## Personas
As personas levantadas durante o processo de entendimento do problema são apresentadas nas figuras que se seguem.

### João Victor Souza
<img height="300px" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/main/docs/img/persona-joao.jpg" />

Idade: 28 <br>
Ocupação: Comprador <br>
João Victor trabalha  como comprador há 4 anos, seu hobbie favorito é o ciclismo. Adora tomar café e viajar para sua casa no lago no final de semana com a família.

### Amanda Carvalho
<img height="300px" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/main/docs/img/persona-amanda.jpg" />

Idade: 36 <br>
Ocupação: Fornecedora <br>
Amanda Carvalho trabalha como fornecedora há 7 anos. Seu hobbie favorito é passear no parque com seus amigos. Também ama fazer trilha e nadar na cachoeira.

### Hugo Barbosa 
<img height="300px" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/main/docs/img/persona-hugo.jpg" />

Idade: 46 <br>
Ocupação: Fornecedor <br>
Hugo Barbosa é um agricultor apaixonado por alimentação saudável e pela agricultura sustentável. Seus hobbies  são cavalgar em sua fazenda durante os fins de semana e música.

### Roger Silva
<img height="300px" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/main/docs/img/persona-roger.jpg" />

Idade: 24 <br>
Ocupação: Comprador <br>
Roger é um gerente de compras em um hortifruti local. Sua principal responsabilidade é garantir que a empresa tenha seu estoque regulado. Seu hobbie é jogar jogos online e ler livros sci-fi.

### Ana Resende
<img height="300px" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/main/docs/img/persona-ana.jpg" />

Idade: 38 <br>
Ocupação: Fornecedora <br>
A empresa de Ana trabalha com fornecimento há muito tempo. Ela adora ser responsável pelos alimentos que chegam no lar das pessoas. Seu passatempo favorito é a culinária.

## Histórias de Usuários
Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
| Amanda Carvalho  | Desejo ajustar os meus preços para cada comprador que abriu a solicitação           | para oferecer preços personalizados.              |
| Hugo Barbosa    | Desejo receber as cotações de forma padronizada com os campos de valores e quantidade               | a fim de otimizar o meu processo. |
| Ana Resende | Quero receber uma indicação de quando o processo de cotação for aberto | para informar os preços dentro do prazo. |
| Hugo Barbosa | Quero que o nome da minha empresa fique em destaque | para que os compradores consigam identificar com facilidade. |
| Amanda Carvalho | Quero poder cadastrar os meus produtos | para ter mais controle sobre os pedidos. |
| João Victor Souza | Quero poder fazer a revisão do pedido na cotação | para que eu não fique sem estoque  dos produtos. |
| João Victor Souza | Quero ter uma comunicação clara com o fornecedor | para agilizar os meus pedidos. |
| Roger Silva | Quero poder me cadastrar, alterar e excluir minhas informações | para me sentir seguro com os meus dados. |

## Requisitos

### Requisitos Funcionais
A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues.

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-01| O sistema deve permitir que os fornecedores ajustem o preço para cada comprador correspondente. | ALTA | 
|RF-02| O sistema deve permitir que o comprador e fornecedor ajustem a quantidade de itens solicitados. | ALTA |
|RF-03| O sistema deve enviar uma mensagem informando a abertura e fechamento da cotação solicitada. | MÉDIA |
|RF-04| O sistema deve mostrar o nome do fornecedor com clareza. | MÉDIA |
|RF-05| O sistema deve permitir um canal de comunicação entre fornecedor e comprador. | ALTA|
|RF-06| O sistema deve permitir que o comprador e fornecedor possam fazer a revisão do pedido antes do fechamento e do envio da mensagem. | ALTA |
|RF-07| O sistema deve permitir o cadastro, edição e exclusão dos produtos de hortifruti contendo imagem, nome, código único do item e quantidade em estoque. | ALTA |
|RF-08| O sistema deve permitir que o fornecedor e comprador possam cadastrar, alterar e excluir seu cadastro. | ALTA |
|RF-09| O sistema deve permitir que o fornecedor feche o pedido e que o comprador finalize a cotação após a revisão. | ALTA |

### Requisitos não Funcionais
A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender.

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-01| O site deve ser publicado em um ambiente acessível publicamente na Internet (a definir).  | ALTA | 
|RNF-02| O site deverá ser responsivo permitindo a visualização em um celular de forma acessível |  ALTA | 
|RNF-03| O site deve ser compatível com os principais navegadores do mercado. | ALTA |
|RNF-04| O site deve cumprir com boas práticas de acessibilidade, como por exemplo: contraste adequado, atributos para leitores de tela, tags semânticas em HTML, etc. | MÉDIA |

## Restrições
As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 06/12/2023. |
|RE-02| A equipe não pode subcontratar o desenvolvimento do trabalho. |
|RE-03| O projeto não deve usar sistemas de IAs para o desenvolvimento do código. |
|RE-04| O projeto deve ser limitado a linguagem de programação C#. |
|RE-05| O projeto deve ser limitado a um banco de dados relacional. |
|RE-06| Caso seja usado algum framework front-end, usar bootstrap. |

## Diagrama de Casos de Uso
O diagrama de casos de uso representa todas as funcionalidades do nosso sistema, mostrando os casos de uso, atores e seus respectivos relacionamentos.

<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t2-grupo-2-hortidot/blob/7f7567aca891e8c89ef8054409c2cf22d54540e6/docs/img/Diagrama%20Casos%20de%20Uso.jpg" />
