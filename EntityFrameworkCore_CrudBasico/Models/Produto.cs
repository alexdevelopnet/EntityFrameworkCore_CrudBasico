namespace EntityFrameworkCore_CrudBasico.Models
{
    public class Produto : EntityBase
    {          
        public string Nome { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
