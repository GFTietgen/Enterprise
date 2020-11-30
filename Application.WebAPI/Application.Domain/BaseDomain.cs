using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Domain
{

    /// <summary>
    /// Entidade base para as classes do sistema
    /// </summary>
    public class BaseDomain
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public string dtCadastro { get; set; }
        public string dtAlteracao { get; set; }
        public string dtInativacao { get; set; }
    }
}
