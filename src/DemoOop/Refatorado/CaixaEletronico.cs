using System;

namespace DemoOop.Refatorado
{
    public class CaixaEletronico
    {
        public static void Operacoes()
        {

            Menu.Operacoes();

            var opcao = Console.ReadKey();
            var retorno = string.Empty;


            var movimento = new Movimento();
            var debitoConta = movimento.DadosDebito(opcao, retorno);


            Transacao.Retorno(retorno, debitoConta.Valor, debitoConta.Conta);

        }
    }
}
