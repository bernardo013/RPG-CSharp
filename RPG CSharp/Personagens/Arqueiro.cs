    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace RPG_CSharp.Personagens
    {
        public class Arqueiro : Personagem
        {
            public int DanoEspecial { get; set; }
            public int DanoCausado { get; set; }

        //Método Construtor
        public Arqueiro(string Nome, int Vida, int Ataque, int Defesa)
                : base(Nome, Vida, Ataque, Defesa) { }

            //Métodos sobrescritos da classe base Personagem
            public override void Atacar(Personagem alvo)
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
        public override void ReceberDano(int DanoRecebido)
            {
                base.ReceberDano(DanoRecebido);
            }

            //Método especial do Arqueiro: Atira uma chuva de flechas.
            public override void Especial(Personagem alvo)
            {
                   DanoEspecial = this.Ataque * 3;


                if (DanoEspecial < 0)
                {
                    DanoEspecial = 0;
                }
                else
                {
                    Console.WriteLine($"{Nome} usou a chuva de flechas em {alvo.Nome}, causando {DanoEspecial} de dano!");
                    alvo.ReceberDano(DanoEspecial);
                }
            }
        }

    }

