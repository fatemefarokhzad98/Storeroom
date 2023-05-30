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
            DataFile.AddProducts(storageModel);
            DataFile.AddTime(storageModel.Id, DataFile.MiladiToShamsi(DateTime.Now));
            return RedirectToAction("ShowProduct");
        }
        
        public IActionResult DeleteProduct(StorageModel storageModel)
        {
            DataFile.DeletProduct(storageModel);
            DataFile.DeleteTime(storageModel.Id, DataFile.MiladiToShamsi(DateTime.Now));
            return View();
        }
      
        [HttpGet]
        public IActionResult  EditProduct(int id)
        {

           

            return View(DataFile.GetId(id));
        }
        [HttpPost]
        public IActionResult EditProduct(StorageModel storageModel)
        {
            DataFile.EditProduct(storageModel);
            return RedirectToAction("ShowProduct");
        }
        public IActionResult ShowProduct()
        {
            var Products=DataFile.ShowProduct();
            return View(Products);
        }
    }
}
