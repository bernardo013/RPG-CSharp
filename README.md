# RPG CSharp

Criando um jogo simples de batalha por turnos no console, usando C#, aplicando os conceitos vistos nos três cursos da Alura: fundamentos da linguagem, orientação a objetos, herança e interfaces.

11/11 - 11:30 Primeiro commit realizado com a criação da classe Mãe "Personagem" e as subclasses Mago, Arqueiro e Guerreiro.
Realizei o primeiro teste no arquivo Program.cs aonde fiz a instância do Mago e Guerreiro e realizei o primeiro ataque, seguido da exibição de status atualizada do guerreiro.

12/11 - 8:40 Sobrescrevi todas os métodos da classe mãe nas subclasses Mago, Arqueiro e Guerreiro. Além disso criei o méotodo Especial com ataques únicos para cada personagem. Defesa caindo de 1 em 1 independente do dano causado. Código comentado e identado.  

12/11 - 18:00 Criação da Interface IAtacavel e definição dos métodos atacar() e especial() como abstratos para que as subclasses subscrevam obrigatoriamente estes métodos em seus escopos. 
