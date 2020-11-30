using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Domain.Concretas
{
    public class Funcionario : Usuario
    {
        public Funcionario() { }

        /// <summary>
        /// Construtor para cadastro de novos funcionarios
        /// </summary>
        public Funcionario(string _nome, string _cpf_cnpj, string _uf_rg, string _rg)
        {
            Nome     = _nome;
            CPF_CNPJ = _cpf_cnpj;
            UF_RG    = _uf_rg;
            RG       = _rg;
        }

        /// <summary>
        /// Construtor para alteração ou apresentação
        /// </summary>
        public Funcionario(int _id, string _nome, string _cpf_cnpj, string _uf_rg, string _rg)
        {
            ID       = _id;
            Nome     = _nome;
            CPF_CNPJ = _cpf_cnpj;
            UF_RG    = _uf_rg;
            RG       = _rg;
        }


        public string Nome { get; private set; }
        public string CPF_CNPJ { get; private set; }
        public string UF_RG { get; private set; }
        public string RG { get; private set; }
    }
}
