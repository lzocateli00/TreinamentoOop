namespace OOP
{

    /// <summary>
    /// Exemplo de implementação incorreta, com alto acoplamento
    /// </summary>
    public class Implementacao
    {
        private readonly Repositorio repositorio;

        public Implementacao()
        {
            repositorio = new Repositorio();
        }


        public void Processo()
        {

            var cliente = new ClientePessoaFisica(new Pessoa());

            repositorio.Adicionar(cliente);
        }
    }
}