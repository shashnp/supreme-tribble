using System.Web.Mvc;
using WebApplication1.Interfaces;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;

        //inject dependency 
        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        // GET: Product
        public ActionResult Index()
        {
            var data = _repository.GetAll();
            return View(data);
        }
    }
}