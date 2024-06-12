using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class Comentarios
    {
        public static void Executar()
        {
            // Comentário de uma única linha
            Console.WriteLine("Código claro é sempre melhor!");

            /* Comentário
                de
                múltiplas linhas
            */

            /// <summary>
            /// comentário XML
            /// </summary>

            Console.WriteLine("O C# tem comentários de XML");

        }
    }
}