using CrudViewModel.Models;
using CrudViewModel.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CrudViewModel.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _product;
        public ProductsController(IProductRepository product)

        {
            _product = product;
        }

        public async Task< IActionResult> Index()
        {
            var Products = await _product.GetAllAsync();    


            return View(Products);
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
       
    }

}


