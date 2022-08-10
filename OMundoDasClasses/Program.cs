using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte1
{
    class Program //Sem modificador de acesso explícito = internal por padrão
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(Cor.Branco, 4, "Gol G6"); //criando carro
            Console.WriteLine(carro.Ligar()); //Ligar carro
            Console.WriteLine("Ligado? " + carro.Ligado);
            Console.WriteLine(carro.Andar()); //Andar com carro
            Console.WriteLine(carro.Desligar()); //DesLigar carro
            Console.WriteLine("Ligado? " + carro.Ligado);

            //Exibindo atributos do carro
            Console.WriteLine("O carro é um " + carro.Modelo + " de cor " + carro.Cor + " e tem " + carro.Portas + " portas.");

            carro.Cor = Cor.Azul;
            Console.WriteLine("A cor do carro agora é: " + carro.Cor);

        }
    }
}
