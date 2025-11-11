using RPG_CSharp.Personagens;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public static void Batalha() {
            Mago Gandalf = new Mago("Gandalf", 100, 30, 5);
            Guerreiro Euclides = new Guerreiro("Euclides", 150, 10, 15);
            Gandalf.Atacar(Euclides);
            Euclides.ExibirStatus();

        
        }
    }
}
