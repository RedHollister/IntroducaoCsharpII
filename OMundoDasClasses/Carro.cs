using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte1
{
    public class Carro
    {
        //atributos do carro
        public Cor Cor { get; set; }
        public int Portas { get; }
        public string Modelo { get; }

        private bool ligado = false; //private só a classe tem acesso

        public bool Ligado //Propriedade: define uma maneira de acessar atributos
        {
            get //retorna valor
            {
                return ligado;
            }
        }

        //Método construtor da classe
        public Carro(Cor cor, int portas, string modelo)
        {
            Cor = cor;
            Portas = portas;
            Modelo = modelo;
        }

        //Comportamentos do carro
        public string Ligar()
        {
            ligado = true;
            return "O carro foi ligado.";
            
        }
        public string Desligar()
        {
            ligado = false;
            return "O carro foi desligado";
            
        }

        public string Andar()
        {
            return "O Carro está andando.";
        }
    }
}
