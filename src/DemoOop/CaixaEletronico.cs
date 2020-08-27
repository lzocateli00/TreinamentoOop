using System;
using System.IO;

namespace DemoOop
{
    public class CaixaEletronico
    {
        public static void Operacoes()
        {

            /// Exibindo o menu para o usuario
            Console.Clear();
            Console.WriteLine("Caixa Eletrônico");
            Console.WriteLine("Escolha sua opção:");
            Console.WriteLine();
            Console.WriteLine("1 - Saque Conta Corrente");
            Console.WriteLine("2 - Saque Conta Poupança");
            Console.WriteLine("3 - Saque Conta Investimento");

            /// Aguarda que o usuario escolha uma opção
            var opcao = Console.ReadKey();
            var retorno = string.Empty;
            var debitoConta = new DebitoConta();


            /// Cria uma linha de divisão na tela
            Console.WriteLine();
            Console.WriteLine("..............................");
            Console.WriteLine();

            /// Usuario informa Conta e Valor
            Console.WriteLine("Digite a Conta");
            var conta = Console.ReadLine();

            Console.WriteLine("Digite o Valor");
            if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
                valor = 0;



            /// Executa a operação conforme a escolha do usuario
            switch (opcao.KeyChar)
            {
                case '1':
                    Console.WriteLine("Efetuando operação em Conta Corrente");
                    retorno = debitoConta.Debitar(valor, conta, TipoConta.Corrente);
                    break;
                case '2':
                    Console.WriteLine("Efetuando operação em Conta Poupança");
                    retorno = debitoConta.Debitar(valor, conta, TipoConta.Poupanca);
                    break;
                case '3':
                    Console.WriteLine("Efetuando operação em Conta Investimento");
                    //retorno = debitoConta.Debitar(valor, conta, TipoConta.);
                    break;
            }


            /// Retorna o codigo da operação
            Console.WriteLine();
            Console.WriteLine("Sucesso! Transação: " + retorno + " em " + DateTime.Now);
            Console.WriteLine("          Valor R$: " + valor + " debitado na conta: " + conta);
            Console.ReadKey();

        }

    }
}
