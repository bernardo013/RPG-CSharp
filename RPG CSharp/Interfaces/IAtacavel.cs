using RPG_CSharp.Personagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_CSharp.Interfaces
{
    public interface IAtacavel
    {
        void Atacar(Personagem alvo);
        void Especial(Personagem alvo);

    }
}
