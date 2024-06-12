using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    public class VariaveisEConstantes
    {
        public static void Executar()
        {
            // Área da circuferência
            double raio = 4.5;
            const double PI = 3.14; // por ser constante não vai poder ser alterada

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Esá chovendo: " + estaChovendo);

            byte idade = 45; // equivale a 8 bits, não faz sentido usar, pode usar o tipo number e int
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MinValue; // mesma questão do byte, porém armazena em mais bits que o byte
            Console.WriteLine("Saldo de Gols: " + saldoDeGols);

            short salario = short.MaxValue; // mesma questão do byte, porém armazena em mais bits que o sbyte
            Console.WriteLine("Salário: " + salario);

            int menorValorInt = int.MinValue; //Mais usados dos interios
            Console.WriteLine("Menor int: " + menorValorInt);

            uint populacaoBrasileira = 207_600_000; // inteiro sem sinal
            Console.WriteLine("População Brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long: " + menorValorLong);

            ulong populacaoNacional = 7_600_000_000;
            Console.WriteLine("População Nacional: " + populacaoNacional);

            float precoComputador = 1299.99f; // para identicar como float precisa por o f na frente do número
            Console.WriteLine("Preço Computador: " + precoComputador);

            double valorDeMercadoApple = 1_000_000_000_000.00; // Mais usado
            Console.WriteLine("Valor de mercado da Apple: " + valorDeMercadoApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas: " + distanciaEntreEstrelas);

            char letra = 'a'; // armazena uma única letra e utiliza aspa simples
            Console.WriteLine("Letra: " + letra);

            string texto = "Seja bem vindo!"; // armazena um conjunto de caracteres e utiliza aspas duplas
            Console.WriteLine("Texto: " + texto);

        }
    }
}