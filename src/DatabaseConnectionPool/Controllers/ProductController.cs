using DatabaseConnectionPool.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DatabaseConnectionPool.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository productRepository;

        public ProductController()
        {
            productRepository = new ProductRepository();
        }
        public async Task<IActionResult> Index()
        {
            var result = await productRepository.FindAll();
            return View(result);
        }
    }
}