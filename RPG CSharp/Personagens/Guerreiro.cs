using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_CSharp.Personagens
{
    internal class Guerreiro : Personagem
    {
        public Guerreiro(string Nome, int Vida, int Ataque, int Defesa) 
            : base(Nome, Vida, Ataque, Defesa) { }

        public override void Atacar(Personagem alvo)
        {
            base.Atacar(alvo);
        }

        public override void ReceberDano(int danoRecebido)
        {
            base.ReceberDano(danoRecebido);
        }

    }
}
