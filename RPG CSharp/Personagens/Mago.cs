    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace RPG_CSharp.Personagens
    {
        public class Mago : Personagem
        {

            public int DanoEspecial { get; set; }

            //Método Construtor
            public Mago(string Nome, int Vida, int Ataque, int Defesa)
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

            //Método Especial do Mago: Ataque Mágico( dano padrão + 10)
            public override void Especial(Personagem alvo)
            {
                DanoEspecial = (this.Ataque + 10);

                if (DanoEspecial < 0)
                {
                    DanoEspecial = 0;
                }
                else
                {
                    Console.WriteLine($"{Nome} usou Ataque Mágico em {alvo.Nome}, causando {DanoEspecial} de dano!");
                    alvo.ReceberDano(DanoEspecial);
                }
            }

        }
    }
