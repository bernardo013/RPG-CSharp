    using RPG_CSharp.Personagens;
    using System;
    using System.Collections.Generic;
    using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
    using System.Threading.Tasks;

    namespace RPG_CSharp
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Batalha();
            }
        //Instancia da classe Mago e Guerreiro e simulação de batalha entre eles.
        //Criação do Método batalha
        public static void Batalha()
        {
            Mago mago = new Mago("Mago - Gandalf", 100, 15, 5);
            Arqueiro arqueiro = new Arqueiro("Arqueiro - Oliver", 120, 12, 5);
            Guerreiro guerreiro = new Guerreiro("Guerreiro - Euclides", 150, 10, 10);

            Personagem jogador1 = null;
            Personagem jogador2 = null;

            Console.WriteLine("Escolha seu personagem: ");
            Console.WriteLine("1 - Mago");
            Console.WriteLine("2 - Arqueiro");
            Console.WriteLine("3 - Guerreiro");
            string escolha = Console.ReadLine();


            if (escolha == "1")
            {
                jogador1 = mago;
                jogador2 = guerreiro;
            }
            else if (escolha == "2")
            {
                jogador1 = arqueiro;
                jogador2 = mago;
            }
            else if (escolha == "3")
            {
                jogador1 = guerreiro;
                jogador2 = arqueiro;
            }
            else
            {
                Console.WriteLine("Escolha inválida, será atribuído Mago como personagem.");

            }


            // Inicio da batalha
            while (jogador1.Vida > 0 && jogador2.Vida > 0)
            {
              
                jogador1.ExibirStatus();
                jogador2.ExibirStatus();

                Console.WriteLine($"Turno de {jogador1.Nome}");
                Console.WriteLine("1 - Atacar");
                Console.WriteLine("2 - Especial");

                //variavel que recebe a ação do jogador1 e converte para inteiro, se for nulo, atribui 1 como padrão.
                int acao = int.Parse(Console.ReadLine() ?? "1");

                if (acao == 1)
                {
                    jogador1.Atacar(jogador2);
                    
                }
                else {
                    jogador1.Especial(jogador2);
                    
                }

                if (jogador2.Vida <= 0) break;

                Console.WriteLine($"Turno de {jogador2.Nome}");
                Console.WriteLine("1 - Atacar");
                Console.WriteLine("2 - Especial");

                //variavel que recebe a ação do jogador2 e converte para inteiro, se for nulo, atribui 1 como padrão.
                int acao2 = int.Parse(Console.ReadLine() ?? "1");

                if (acao2 == 1)
                {
                    jogador2.Atacar(jogador1);
                    
                }
                else
                {
                    jogador2.Especial(jogador1);
                    
                }

                Console.WriteLine("-----------------------------");
            }

            // Resultado final
            Console.WriteLine("FIM DA BATALHA ");
            if (jogador1.Vida > 0)
                Console.WriteLine($"{jogador1.Nome} venceu!");
            else if (jogador2.Vida > 0)
                Console.WriteLine($"{jogador2.Nome} venceu!");
            else
                Console.WriteLine("Empate!");
        }

       }
    }

    
    
