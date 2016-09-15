using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SW3_TR_1Bim.Models
{
    public class Cliente
    {

        public int ClienteID { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Nacionalidade { get; set; }

        public string RG { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }

        public Sexo sexo { get; set; }

        public string Pais { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Bairro { get; set; }

        public string Rua { get; set; }

        public int Numero { get; set; }

    }
}