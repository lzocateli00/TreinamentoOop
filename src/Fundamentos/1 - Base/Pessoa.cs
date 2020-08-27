using System;

namespace OOP
{

    /// <summary>
    /// Uma Classe precisa ter Estado e Coportamento
    /// </summary>
    /// <remarks>
    ///  Superclasse = Classe Mãe
    /// </remarks>
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;
                                 
            return idade;
        }

        public void Totalizar()
        {

        }
        private string MeuMetodo()
        {
            return "";
        }
    }
}