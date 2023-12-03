# Registro de Testes de Usabilidade

Para realizar os testes de usabilidade, foi desenvolvido um plano de testes que propõe a utilização do System Usability Scale (SUS), que consiste em um questionário com 10 questões em escala Likert aplicado após o usuário usar o sistema ou conhecer como ele funciona. Após a aplicação do questionário, deve-se fazer o cálculo de pontuação pré-definido pelo método para avaliar a usabilidade do sistema. Usa-se como referência para análise do resultado o valor de 68 pontos. Um resultado abaixo de 50 é um sinal de que problemas de usabilidade podem levar ao insucesso do sistema. 

O teste de usabilidade utilizado é investigativo, onde dois participantes, sendo um comprador e um fornecedor, foram contextualizados sobre a aplicação HortiDot e realizaram os testes seguindo uma série de comandos pré-estabelecidos e tiveram um facilitador. Os usuários têm uma vasta experiência nas áreas de compras e fornecimento, tendo a idade de 30 e 31 anos, respectivamente, e facilidade com tecnologia. 

A seguir estão os resultados obtidos pela avaliação. Os testes foram registrados em vídeo e se encontram na pasta "presentation".

### Questionário System Usability Scale (SUS)

#### Comprador

| | Itens                                                | Discordo Completamente | Discordo | Não Concordo e Nem Discordo | Concordo | Concordo Completamente |
|-| ---------------------------------------------------- | ---------- | ---- | --- | ----- | --------- |
| |                                                          | 1          | 2    | 3   | 4     | 5         |
|1| Eu acho que gostaria de usar esse sistema com frequência.| | | | X | |
|2| Eu acho o sistema desnecessariamente complexo.           | | X | | | |
|3| Eu achei o sistema fácil de usar.                        | |  | | x | |
|4| Eu acho que precisaria de ajuda de uma pessoa com conhecimentos técnicos para usar o sistema.| | X | | | |
|5| Eu acho que as várias funções do sistema estão muito bem integradas. | | | X | | |
|6| Eu acho que o sistema apresenta muita inconsistência. | | X | | | |
|7| Eu imagino que as pessoas aprenderão como usar esse sistema rapidamente. | | | X | | |
|8| Eu achei o sistema atrapalhado de usar. | | | X | | |
|9| Eu me senti confiante ao usar o sistema. | | | | X | |
|10| Eu precisei aprender várias coisas novas antes de conseguir usar o sistema. | | x  | | | | 

#### Fornecedor
| | Itens                                                | Discordo Completamente | Discordo | Não Concordo e Nem Discordo | Concordo | Concordo Completamente |
|-| ---------------------------------------------------- | ---------- | ---- | --- | ----- | --------- |
| |                                                          | 1          | 2    | 3   | 4     | 5         |
|1| Eu acho que gostaria de usar esse sistema com frequência.| | | x | | |
|2| Eu acho o sistema desnecessariamente complexo.           | x | | | | |
|3| Eu achei o sistema fácil de usar.                        | | | | x | |
|4| Eu acho que precisaria de ajuda de uma pessoa com conhecimentos técnicos para usar o sistema.| | x | | | |
|5| Eu acho que as várias funções do sistema estão muito bem integradas. | | | x | | |
|6| Eu acho que o sistema apresenta muita inconsistência. | | | x | | |
|7| Eu imagino que as pessoas aprenderão como usar esse sistema rapidamente. | | | x | | |
|8| Eu achei o sistema atrapalhado de usar. | | x |  | | |
|9| Eu me senti confiante ao usar o sistema. | | | | x | |
|10| Eu precisei aprender várias coisas novas antes de conseguir usar o sistema. | x | | | | | 

### Cálculo da Pontuação

Como citado anteriormente, o SUS possui um método próprio de pontuação. Primeiro faz-se a conversão:
- Para itens ímpares (1, 3, 5, 7, 9) subtrai-se 1 da pontuação que o usuário respondeu.
- Para itens pares (2 , 4, 6, 8, 10) subtrai-se a resposta do usuário de 5.

Por fim, soma-se todos os valores das 10 respostas convertidas e multiplica-se por 2.5. Essa é a pontuação final, que pode ir de 0 a 100. 

O questionário respondido pelo comprador resultou em 68 pontos, e o questionário respondido pelo fornecedor resultou em 70 pontos.

Com o resultado apresentado, pode-se concluir que algumas funções propostas foram executadas com êxito, como o cadastro, edição de dados e exclusão de dados de usuários e produtos e o login. As funções que não tiveram êxito, como a criação de pedidos e funcionalidades relacionadas, foram um obstáculo para os avaliadores.

### Problemas apresentados

Os usuários tiveram problemas em alguns pontos do sistema, porém, tinham o contexto da situação. Infelizmente não foi possível adicionar algumas funcionalidades descritas nos requisitos funcionais, são estes:

* RF-01 - O sistema deve permitir que os fornecedores ajustem o preço para cada comprador correspondente.<br>
* RF-02 -	O sistema deve permitir que o comprador e o fornecedor ajustem a quantidade de itens solicitados.<br>
* RF-03 - O sistema deve permitir que o comprador e o fornecedor possam fazer a revisão do pedido antes do fechamento.<br>
* RF-06 - O sistema deve permitir que o fornecedor feche o pedido e que o comprador finalize a cotação após a revisão.<br>

A tela Pedidos foi um desafio para a equipe devido ao curto tempo para o desenvolvimento. A proposta da tela Pedidos era permitir que o comprador fizesse a abertura de um pedido, acrescentando os itens desejados previamente cadastrados. O fornecedor receberia esse pedido e forneceria os preços solicitados, enviando uma proposta ao comprador, que por sua vez poderia aceitar ou recusar a proposta. Sem a implementação da tela Pedidos, uma parte importante do sistema foi comprometida.

Outro problema identificado foi a tentativa de voltar à tela inicial da aplicação após fazer a edição de dados de um usuário. Para solucionar o problema temporariamente, foi necessário encaminhar o usuário à tela de login. 










