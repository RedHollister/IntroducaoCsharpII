using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCalculadora
{
    /// <summary>
    /// Classe com operações matemáticas básicas
    /// </summary>
    public static class OperacoesAritmeticas //Uma classe estática: não pode ser instanciada, não pode herdar e nem ser herdada, só pode conter membros estáticos
    {
        /// <summary>
        /// Operação básica de adição
        /// </summary>
        /// <param name="parcela1">
        /// A primeira parcela</param>
        /// <param name="parcela2">
        /// A segunda parcela</param>
        /// <returns>
        /// A soma dos números informados
        /// </returns>
        public static double Adicao(double parcela1, double parcela2)
        {
            return parcela1 + parcela2;
        }

        /// <summary>
        /// Operação Básica de subtração
        /// </summary>
        /// <param name="minuando"></param>
        /// <param name="subtraendo"></param>
        /// <returns>
        /// A subtração de dois números
        /// </returns>
        public static double Subtracao(double minuando, double subtraendo)
        {
            
            return minuando - subtraendo;
        }

        /// <summary>
        /// operação básica de multiplicação
        /// </summary>
        /// <param name="multiplicando"></param>
        /// <param name="multiplicador"></param>
        /// <returns>
        /// O Produto Multiplicado
        /// </returns>
        public static double Multiplicacao(double multiplicando, double multiplicador)
        {
            return multiplicando * multiplicador;
        }

        /// <summary>
        /// Operação Básica de Divisão
        /// </summary>
        /// <param name="dividendo"></param>
        /// <param name="divisor"></param>
        /// <returns>
        /// O Resultado dividido
        /// </returns>
        public static double Divisao(double dividendo, double divisor)
        {
            return dividendo / divisor;
        }
    }
}
