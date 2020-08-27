namespace OOP
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }


        private void Teste()
        {
            CalcularIdade();
        }
        

                
    }


    /// <summary>
    /// Prefira sempre composição a Herança
    /// Herança viola o encapsulamento, pois expõe a implementação
    /// Aqui o acoplamento é menor, e a coesao é mais alta (Aderencia, Harmonia).
    /// Contudo ainda não é a melhor abordagem, que seria "Interface"
    /// </summary>
    public class ClientePessoaFisica
    {
        private readonly Pessoa _pessoa;

        public ClientePessoaFisica(Pessoa pessoa)
        {
            _pessoa = pessoa;
            _pessoa.CalcularIdade();

        }


        public string CPF { get; set; }

    }



    public class Teste : ClientePessoaFisica
    {
        public Teste(Pessoa pessoa) 
            : base(pessoa)
        {
           
        }

        
    }
}