using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_CSharp.Personagens
{
    public class Personagem
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }


        public Personagem(string Nome, int Vida, int Ataque, int Defesa) { 
        
            this.Nome = Nome;
            this.Vida = Vida;  
            this.Ataque = Ataque;
            this.Defesa = Defesa;
        } 


        public virtual void Atacar(Personagem alvo)
        {

            int danoCausado = this.Ataque - alvo.Defesa;


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

        public virtual void ReceberDano(int danoRecebido)
        {
            Vida -= danoRecebido;

            if (Vida < 0)
            {
                Vida = 0;
            }

            Console.WriteLine($"{Nome} recebeu {danoRecebido} de dano! Vida restante: {Vida}");
        }

       public virtual void Especial() { }


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
