using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Domain.Concretas
{
    public class Usuario : BaseDomain
    {
        public string UserName { get; set; }
        public string UserPwd { get; set; }
    }
}
