using EntityFrameworkCore_CrudBasico.Interfaces;
using EntityFrameworkCore_CrudBasico.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkCore_CrudBasico.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase, new()
    {
        protected readonly ContextoCrudBasico _contexto;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(ContextoCrudBasico contexto)
        {
            this._contexto = contexto;
            DbSet = contexto.Set<TEntity>();
        }
        public IList<TEntity> ListarTodos()
        {
            return DbSet.ToList();
        }

        public TEntity ObterPorId(int id)
        {
            return DbSet.AsNoTracking().Where(e => e.Id == id).FirstOrDefault();
        }
        public void Inserir(TEntity entity)
        {
            DbSet.Add(entity);
            SaveChanges();

        }
        public void Alterar(TEntity entity)
        {
            DbSet.Update(entity);
            SaveChanges();
        }

        public void Excluir(TEntity entity)
        {
            DbSet.Remove(entity);
            SaveChanges();
        }
        public int SaveChanges()
        {    
            return _contexto.SaveChanges();
        }
    }
}
