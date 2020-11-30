using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Contracts.Data
{
    /// <summary>
    /// Interface para acesso e persistencia dos dados
    /// </summary>
    /// <typeparam name="TEntity">Qual tipo será processado</typeparam>
    /// <typeparam name="TReturn">Qual será o retorno comum</typeparam>
    public interface IRepository<TEntity, TReturn>
    {
        /// <summary>
        /// Método para cadastro
        /// </summary>
        TReturn Create(TEntity data);

        /// <summary>
        /// Método para listagem
        /// </summary>
        List<TEntity> Read();

        /// <summary>
        /// Método para retorno de registro especifico
        /// </summary>
        TEntity Read(int id);

        /// <summary>
        /// Método para alteração
        /// </summary>
        TReturn Update(TEntity data);

        /// <summary>
        /// Método para deletar/inativar registro
        /// </summary>
        TReturn Delete(int id);
    }
}
