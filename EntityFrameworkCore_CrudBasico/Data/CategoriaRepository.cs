using EntityFrameworkCore_CrudBasico.Interfaces;
using EntityFrameworkCore_CrudBasico.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EntityFrameworkCore_CrudBasico.Data
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(ContextoCrudBasico context) : base(context) { }
         

    }
}
