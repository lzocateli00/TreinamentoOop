using System;

namespace DemoOop
{
    public class DebitoConta
    {
        public string NumeroTransacao { get; set; }


        public string Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.Corrente)
            {
                // Debita Conta Corrente

                Console.WriteLine($"Debito: {valor}");
                Console.WriteLine($"Conta: {conta}");

            }

            if (tipoConta == TipoConta.Poupanca)
            {
                // Valida Aniversário da Conta
                // Credito Conta Corrente

                Console.WriteLine($"Debito: {valor}");
                Console.WriteLine($"Conta: {conta}");
            }


            return FormatarTransacao();
        }


        public string FormatarTransacao()
        {
            var random = new Random();
            var guid = Guid.NewGuid().ToString();

            NumeroTransacao = $"{guid.Split('-')[1]}_XYZ_{random.Next()}";

            // Numero de transacao formatado
            return NumeroTransacao;
        }
    }
}
