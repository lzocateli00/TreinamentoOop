using System;

namespace DemoOop.Refatorado
{
    public class DebitoContaCorrente : DebitoConta
    {

        public DebitoContaCorrente(decimal valor, string conta)
            : base(valor, conta)
        {

        }



        public override string Debitar()
        {
            // Debita Conta Corrente

            Console.WriteLine($"Debito: {Valor}");
            Console.WriteLine($"Conta: {Conta}");



            return FormatarTransacao();
        }
    }
}
