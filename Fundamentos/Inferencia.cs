using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class Inferencia
    {
        public static void Executar()
        {
            // Var não é muito recomendado, pois vai dificultar a leitura do código e o C# é fortemente tipado
            var nome = "Isabela"; // não estou atribuindo um tipo, mas o C# já entende que é do tipo string
            Console.WriteLine("Nome: " + nome);

            //int idade
            var idade = 32;
            Console.WriteLine("Idade: " + idade);
        }
    }
}