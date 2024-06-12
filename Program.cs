using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundametos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundametos", VariaveisEConstantes.Executar},
                {"Inferência de Tipos - Fundametos", Inferencia.Executar},
                {"Interpolação de String - Fundametos", Interpolacao.Executar},
                {"Notação Ponto - Fundametos", NotacaoPonto.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}