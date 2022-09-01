using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte2
{
    public abstract class Animal //Uma classe abstrate não pode ser instanciada
    {
        public string Nome { get; }
        public int Idade { get; }
        public abstract Som SomEmitido { get; } // Essa propriedade deverá ser implementada por cada classe filha, já que é abstrata
        public virtual string Locomocao { get { return "Está andando"; } } //Essa propriedade poderá ou não ser sobreescrita nas classes filhas

        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
