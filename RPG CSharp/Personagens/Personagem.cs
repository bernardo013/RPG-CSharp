    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace RPG_CSharp.Personagens
    {
        public abstract class Personagem
        {
            public string Nome { get; set; }
            public int Vida { get; set; }
            public int Ataque { get; set; }
            public int Defesa { get; set; }

            //Método Construtor da classe mãe/base
            public Personagem(string Nome, int Vida, int Ataque, int Defesa) { 
        
                this.Nome = Nome;
                this.Vida = Vida;  
                this.Ataque = Ataque;
                this.Defesa = Defesa;
            }

            //Método de Ataque básico. // Deve ser sobrescrito nas classes filhas.
            public virtual void Atacar(Personagem alvo)
            {

                int danoCausado = this.Ataque;


                if (danoCausado < 0)
                {
                    danoCausado = 0;
                    Console.WriteLine($"{Nome} atacou {alvo.Nome} causando {danoCausado} de dano!");
                }
                else
                {
                    Console.WriteLine($"{Nome} atacou {alvo.Nome} causando {danoCausado} de dano!");
                    alvo.ReceberDano(danoCausado);
                }

            }

            //Método de receber dano(chamado pelo método Atacar() para calcular dano recebido.
            // Deve ser sobrescrito nas classes filhas.
            public virtual void ReceberDano(int danoRecebido)
            {


                Vida -= danoRecebido; // vida = vida - danoRecebido.
                Defesa -= 2; // Reduz a defesa em 1 a cada ataque recebido.


                if (Vida < 0)
                {
                    Vida = 0;
                }
                if (Defesa < 0)
                {
                    Defesa = 0;
                }

                Console.WriteLine($"{Nome} recebeu {danoRecebido} de dano! Vida restante: {Vida}");

                if (Vida == 0)
                {
                    Console.WriteLine($"{Nome} foi derrotado!");
                }
            }





            //Método de especial. // por ser abstrato deve ser obrigatoriamente sobrescrito nas classes filhas.
            public abstract void Especial(Personagem alvo);

            //Metódo para exibir status do personagem durante ou depois da batalha.
            public virtual void ExibirStatus()
            {
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Vida: {Vida}");
                Console.WriteLine($"Ataque: {Ataque}");
                Console.WriteLine($"Defesa: {Defesa}");
                Console.WriteLine("--------------------");

            }

        }
    }
