using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOP
{

    /// <summary>
    /// Mude essa classe para abstract e veja a Implementacao, vai quebrar, se o desenvolvedor
    /// tivesse na construção, incluido o abstract, nem seria possivel implementar errado.
    /// Veja a ImplementacaoCorreta, nao quebra
    /// </summary>
    public class Repositorio : IRepositorio
    {
        public void Adicionar(object pessoa)
        {
            // Conecta no banco
            // Adiciona pessoa
        }
    }
}