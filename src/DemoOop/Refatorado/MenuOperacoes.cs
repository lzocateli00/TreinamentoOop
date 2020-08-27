using System;

namespace DemoOop.Refatorado
{
    internal static class Menu
    {
        internal static void Operacoes()
        {
            Console.Clear();
            Console.WriteLine("Caixa Eletrônico - Refatorado");
            Console.WriteLine("Escolha sua opção:");
            Console.WriteLine();
            Console.WriteLine("1 - Saque Conta Corrente");
            Console.WriteLine("2 - Saque Conta Poupança");
            Console.WriteLine("3 - Saque Conta Investimento");
        }
    }
}
