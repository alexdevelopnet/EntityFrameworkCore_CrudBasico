using EntityFrameworkCore_CrudBasico.Interfaces;
using EntityFrameworkCore_CrudBasico.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkCore_CrudBasico.Controllers
{
    
     
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _repository;
        public ProdutoController(IProdutoRepository repository)
        {
            this._repository = repository;    
        }
        public IActionResult Index()
        {
            var produtos = _repository.ListarTodos();
            return View(produtos);
        }
    }
}
