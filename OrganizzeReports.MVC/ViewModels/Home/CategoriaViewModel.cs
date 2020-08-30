using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizzeReports.MVC.ViewModels.Home
{
    public class CategoriaViewModel
    {
        public CategoriaViewModel()
        {
            Categorias = new List<CategoriaItemViewModel>();
        }
        public bool Debito { get; set; }
        public CategoriaItemViewModel CategoriaPai { get; set; }
        public List<CategoriaItemViewModel> Categorias { get; set; }
    }
    public class CategoriaItemViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public bool Selecionada { get; set; }
    }
}
