using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PiesLIstViewModel piesLIstViewModel = new PiesLIstViewModel();
            piesLIstViewModel.Pies = _pieRepository.AllPies;

            piesLIstViewModel.CurrentCategory = "Cheese Cakes";
            return View(piesLIstViewModel);
        } 
    }
}
