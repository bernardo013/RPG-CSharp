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
            //Instancia da classe Mago e Guerreiro e simulação de batalha entre eles.
            //Criação do Método batalha
            public static void Batalha() {
                Mago Gandalf = new Mago("Gandalf", 100, 15, 5);
                Arqueiro Oliver = new Arqueiro("Oliver", 120, 12, 5);
                Guerreiro Euclides = new Guerreiro("Euclides", 150, 10, 10);
                Gandalf.ExibirStatus();


            


            
        
            }
        }
    }
