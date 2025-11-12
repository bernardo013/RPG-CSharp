    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace RPG_CSharp.Personagens
    {
            public class Guerreiro : Personagem
        {
            public int DanoEspecial { get; set; }

            //Método Construtor
            public Guerreiro(string Nome, int Vida, int Ataque, int Defesa) 
                : base(Nome, Vida, Ataque, Defesa) { }

            //Métodos sobrescritos da classe base Personagem
            public override void Atacar(Personagem alvo)
            {
                base.Atacar(alvo);
            }

            public override void ReceberDano(int danoRecebido)
            {
                base.ReceberDano(danoRecebido);
            }

            //Método Especial do Guerreiro: Golpe Poderoso ( dobro de dano )
            public override void Especial(Personagem alvo)
            {
            
                DanoEspecial = (this.Ataque * 2);

                if (DanoEspecial < 0)
                {
                    DanoEspecial = 0;
                }
                else
                {
                    alvo.ReceberDano(DanoEspecial);
                    Console.WriteLine($"{Nome} usou Golpe Poderoso em {alvo.Nome}, causando {DanoEspecial} de dano!");
                }
            }

        }
    }
