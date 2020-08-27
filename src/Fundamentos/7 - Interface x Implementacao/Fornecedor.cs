using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OOP
{
    public class Fornecedor : Repositorio
    {


        public Fornecedor()
        {

        }


        public decimal CalculaCredito()
        {
            ///Regra de negocio para calcular o credito
            return 0;
        }

        public int Ranquear()
        {
            ///Regra de negocio para ranqueamento
            return 5;
        }

        public bool PertenceRegiao(string regiao)
        {
            // Regra de negocio........

            return regiao.Equals("SP");
        }

    }
}