using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkCore_CrudBasico.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
