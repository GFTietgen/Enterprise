using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Contracts.Creational
{
    public interface ISingleton
    {
        ISingleton Instance();
    }
}
