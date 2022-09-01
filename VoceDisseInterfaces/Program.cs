using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoceDisseInterfaces
{
    class Program //Sem modificador de acesso explícito = internal por padrão
    {
        static void Main(string[] args)
        {
            var i = new ImpressoraComum();
            var i2 = new ImpressoraCopiadora();
            
            Console.WriteLine(i.Imprimir("Estou estudando C#"));
            Console.WriteLine(i2.Copiar("Estou estudando C#"));

            CopiarDocumento(new Xerox(), "Hello World!");
        }

        public static void CopiarDocumento(ICopiadora c, string texto)
        {
            Console.WriteLine("Estou copiando o texto a seguir: " + c.Copiar(texto));
        }

    }

}