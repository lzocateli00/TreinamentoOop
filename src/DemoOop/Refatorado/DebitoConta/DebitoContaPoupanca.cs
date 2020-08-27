using System;

namespace DemoOop.Refatorado
{
    public class DebitoContaPoupanca : DebitoConta
    {

        public DebitoContaPoupanca(decimal valor, string conta)
            : base(valor, conta)
        {

        }


        public override string Debitar()
        {
            // Valida Aniversário da Conta

            // Credito Conta Corrente

            Console.WriteLine($"Debito: {Valor}");
            Console.WriteLine($"Conta: {Conta}");


            return FormatarTransacao();
        }

    }
}
