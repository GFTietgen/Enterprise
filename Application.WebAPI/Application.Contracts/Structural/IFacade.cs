using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Contracts.Structural
{
    public interface IFacade<TEntity, TReturn>
    {
        TReturn Create(TEntity data);
        List<TEntity> Read();
        TEntity Read(int id);
        TReturn Update(TEntity data);
        TReturn Delete(int id);
    }
}
