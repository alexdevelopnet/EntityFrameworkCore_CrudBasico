using System.Collections.Generic;

namespace EntityFrameworkCore_CrudBasico.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IList<TEntity> ListarTodos();
        TEntity ObterPorId(int id);
        void Inserir(TEntity entity);
        void Alterar(TEntity entity);
        void Excluir(TEntity entity);
    }
}
