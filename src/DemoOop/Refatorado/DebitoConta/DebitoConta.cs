using System;
using System.Linq;

namespace DemoOop.Refatorado
{
    public abstract class DebitoConta
    {
        public string NumeroTransacao { get; set; }
        public abstract string Debitar();
        public decimal Valor { get; private set; }
        public string Conta { get; private set; }


        public DebitoConta(decimal valor, string conta)
        {
            Valor = valor;
            Conta = conta;
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
