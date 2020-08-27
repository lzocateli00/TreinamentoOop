using System;


namespace DemoOop.Refatorado
{
    public class Movimento
    {

        public DebitoConta DadosDebito(ConsoleKeyInfo opcao, string retorno)
        {
            Console.WriteLine();
            Console.WriteLine("..............................");
            Console.WriteLine();

            /// Usuario informa Conta e Valor
            Console.WriteLine("Digite a Conta");
            var conta = Console.ReadLine();

            Console.WriteLine("Digite o Valor");
            if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
                valor = 0;


            switch (opcao.KeyChar)
            {
                case '1':
                    Console.WriteLine("Efetuando operação em Conta Corrente");
                    var debitoContaCorrente = new DebitoContaCorrente(valor, conta);
                    retorno = debitoContaCorrente.Debitar();

                    return debitoContaCorrente;
                case '2':
                    Console.WriteLine("Efetuando operação em Conta Poupança");
                    var debitoContaPoupanca = new DebitoContaPoupanca(valor, conta);
                    retorno = debitoContaPoupanca.Debitar();

                    return debitoContaPoupanca;
                case '3':
                    Console.WriteLine("Efetuando operação em Conta Investimento");
                    //var debitoContaInvetimento = new DebitoContaInvetimento();
                    //retorno = debitoContaInvetimento.Debitar(valor, conta);
                    break;
            }

            return null;
        }
    }
}
