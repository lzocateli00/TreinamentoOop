using System;

namespace DemoOop.Refatorado
{

    internal static class Transacao
    {
        internal static void Retorno(string retorno, decimal valor, string conta)
        {
            Console.WriteLine();
            Console.WriteLine($"Sucesso! Transação: {retorno} em {DateTime.Now}");
            Console.WriteLine($"          Valor R$: {valor} debitado na conta: {conta}");
            Console.ReadKey();
        }
    }
}
