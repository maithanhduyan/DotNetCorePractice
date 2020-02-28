using DatabaseConnectionPool.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DatabaseConnectionPool.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository _productRepository;

        public ProductController()
        {
            _productRepository = new ProductRepository();
        }
        public async Task<IActionResult> Index()
        {
            Console.WriteLine("Client request");
            var result = await _productRepository.FindAll();
            return View(result);
        }

        public async Task<IActionResult> Index2()
        {
            Console.WriteLine("Client 2 request");
            var result = await _productRepository.FindAll();
            return View(result);
        }
    }
}