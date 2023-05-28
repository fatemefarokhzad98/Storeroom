using Microsoft.AspNetCore.Mvc;
using Storeroommanagement.Models;

namespace Storeroommanagement.Controllers
{
    
    public class StorageController : Controller
    {
        
       
        public IActionResult AddProduct()
        {
            return View();
        }
        [ HttpPost]
        public IActionResult AddProduct(StorageModel storageModel)
        {
            DataStorage.AddProducts(storageModel);
            return RedirectToAction("ShowProduct");
        }
        [HttpPost]
        public IActionResult DeleteProduct(StorageModel storageModel)
        {
            DataStorage.DeleteProducts(storageModel);
            return RedirectToAction("ShowProduct");
        }
        public IActionResult DeleteProduct()
        {

            return View();
        }
        public IActionResult  EditProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EditProduct(StorageModel storageModel)
        {
            DataStorage.EditProducts(storageModel);
            return RedirectToAction("ShowProduct");
        }
        public IActionResult ShowProduct()
        {
            var Products=DataStorage.ShowProducts();
            return View(Products);
        }
    }
}
