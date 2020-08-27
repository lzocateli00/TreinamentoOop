using System;

namespace OOP
{
    public class ImplementacaoCorreta
    {
        private readonly IRepositorio _repositorio;

        public ImplementacaoCorreta(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }


        public void Processo()
        {
            //Correto
            var cliente = new ClientePessoaFisica(new Pessoa() { Nome = "Fulano de Tal", DataNascimento = new DateTime(1946, 10, 27) });
            cliente.CPF = "139.666.444-90";
            _repositorio.Adicionar(cliente);


            //Incorreto
            var fornecedor = new Fornecedor();
            fornecedor.Adicionar(new Pessoa() { Nome = "Edicreiso da Silva", DataNascimento = new DateTime(1977, 04, 06) });



        }
    }



    /// Para utilizar Injeção de dependencia, é necessario ter um container que tem a 
    /// responsabilidade/inteligencia para fazer um SericeLocator (Pattern), e saber
    /// qual é, e onde esta uma implementação de uma determinada interface.
    /// 
    /// Existem ferramentas de terceiros no mercado que fazem esse serviço, contudo
    /// no dotnet core isso é nativo.
    /// 
}