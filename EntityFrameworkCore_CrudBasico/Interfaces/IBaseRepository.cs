using EntityFrameworkCore_CrudBasico.Models;
using System.Collections.Generic;

namespace EntityFrameworkCore_CrudBasico.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : EntityBase
    {
        IList<TEntity> ListarTodos();
        TEntity ObterPorId(int id);
        void Inserir(TEntity entity);
        void Alterar(TEntity entity);
        void Excluir(TEntity entity);
    }
}
