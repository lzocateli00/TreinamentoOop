using System;

namespace OOP
{
    /// <summary>
    /// Reusabilidade
    /// Massssss deve ser utilizada apenas se todo o estado e comportamento fazem
    /// sentido para a classe que herda (classe filha).
    /// 
    /// Superclasse = Pessoa
    /// ClasseConcreta = Funcionario
    /// </summary>
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }

      
    }


}