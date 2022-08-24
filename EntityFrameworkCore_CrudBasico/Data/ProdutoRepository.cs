using EntityFrameworkCore_CrudBasico.Interfaces;
using EntityFrameworkCore_CrudBasico.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkCore_CrudBasico.Data
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ContextoCrudBasico context) : base(context) { }
         
        public IEnumerable<Produto> ObterProdutosCategorias()
        {
            return (IEnumerable<Produto>)_contexto.Produtos.AsNoTracking().Include(navigationPropertyPath: f => f.Categoria)
                .OrderBy(p => p.Nome).ToListAsync();
        }

        
    }
}
