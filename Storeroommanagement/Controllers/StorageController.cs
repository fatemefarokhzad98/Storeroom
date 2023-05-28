using Microsoft.AspNetCore.Mvc;
using Storeroommanagement.Models;

namespace Storeroommanagement.Controllers
{
    
    public class StorageController : Controller
    {
        StorageModel storageModel=new StorageModel();
       
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
        
        public IActionResult DeleteProduct(int id)
        {
            DataStorage.DeleteProducts(id);
            return View();
        }
      
        [HttpGet]
        public IActionResult  EditProduct(int id)
        {
           

            return View(DataStorage.GetId(id));
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
