using Application.Contracts.Structural;
using System.Collections.Generic;

namespace Application.Business.Abstratas
{
    public abstract class AbstractFacade<TEntity, TReturn> : IFacade<TEntity, TReturn>
    {
        public abstract TReturn Create(TEntity data);
        public abstract List<TEntity> Read();
        public abstract TEntity Read(int id);
        public abstract TReturn Update(TEntity data);
        public abstract TReturn Delete(int id);
    }
}
