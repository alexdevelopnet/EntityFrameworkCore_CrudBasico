using EntityFrameworkCore_CrudBasico.Interfaces;
using EntityFrameworkCore_CrudBasico.Models;
using System.Collections.Generic;

namespace EntityFrameworkCore_CrudBasico.Services
{
    public abstract class Service<TEntity> : IService<TEntity> where TEntity : EntityBase, new()
    {
        private readonly IRepository<TEntity> _repository;
        public Service(IRepository<TEntity> repository)
        {
            _repository = repository;
        }
        public IList<TEntity> ListarTodos()
        {
            return _repository.ListarTodos();
        }

        public TEntity ObterPorId(int id)
        {             
           return (TEntity)_repository.ObterPorId(id);
        }
        public void Alterar(TEntity entity)
        {
           _repository.Alterar(entity);
        }

        public void Excluir(TEntity entity)
        {
           _repository.Excluir(entity);
        }

        public void Inserir(TEntity entity)
        {
              _repository.Inserir(entity);
            
        }

       
    }
}
