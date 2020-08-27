namespace OOP
{
    /// <summary>
    /// Não é criar classes abstratas
    /// Abstração é trazer coisas do mundo real para a modelagem de objetos
    /// Essa classe é a abstração minima de um eletrodomestico.
    /// </summary>
    /// <remarks>
    ///   Protected expoe o construtor/variavel para a classe que esta herdando.
    ///   Importante conhecer para fazer a melhor modelagem tatica possivel.
    /// </remarks>
    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;

        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        public abstract void Ligar();
        public abstract void Desligar();
    }


    //Nao é possivel a instancia
    //public class minhaclasse
    //{

    //    public minhaclasse()
    //    {
    //        var teste = new Eletrodomestico();

    //    }


    //}
}