using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCalculadora
{/// <summary>
/// Calcula a Tabuada
/// </summary>
    public class Tabuada
    {
        /// <summary>
        /// Númerodo qual será calculada a tabuada
        /// </summary>
        public int Numero { get; }

        public Tabuada(int numero)
        {
            Numero = numero;
        }

        /// <summary>
        /// realiza o cálculo da tabuada
        /// </summary>
        /// <param name="de">
        /// Ponto de partida para cálculo da tabuada
        /// </param>
        /// <param name="ate">
        /// Ponto final para cálculo da tabuada
        /// </param>
        /// <returns>
        /// Tabuada do número informado dentrodo intervalo fornecido
        /// </returns>
        public string Calcular(int de, int ate)
        {
            var sb = new StringBuilder();
            for(int i = de; i<=ate; i++)
            {
                sb.AppendLine($"{Numero} x {i} = {OperacoesAritmeticas.Multiplicacao(Numero, i)}");
            }
            return sb.ToString();
        }
    }
}
