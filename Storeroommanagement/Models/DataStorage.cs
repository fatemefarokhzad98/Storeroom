﻿

using System.Globalization;
using System.Text;

namespace Storeroommanagement.Models

{
    public static class DataStorage
    {
       

       
        private static List<StorageModel> _storageModels = new List<StorageModel>()
        {
            
            new StorageModel()

            {
                Id=1,
                Model="A10",
                Color="black",
               Brands=Enum.Brands.BrandEnum.Asus,
               Groupsenum=Enum.Groups.GroupsEnum.LopTop
                
              


            },
             new StorageModel()

            {
                Id=2,
                Model="A30",
                Color="green",
                Brands=Enum.Brands.BrandEnum.Samsung,
                Groupsenum=Enum.Groups.GroupsEnum.Mobile


            },
              new StorageModel()

            {
                Id=3,
                Model="A50",
                Color="blue",
               Brands=Enum.Brands.BrandEnum.Asus,
                Groupsenum=Enum.Groups.GroupsEnum.LopTop


            },
                  new StorageModel()

            {
                Id=4,
                Model="A70",
                Color="yellow",
                Brands=Enum.Brands.BrandEnum.Huawi,
                Groupsenum=Enum.Groups.GroupsEnum.Mobile


            },




        };
        public static void AddProducts( StorageModel storageModel)
        {
            storageModel.Id = _storageModels.Last().Id + 1;
            _storageModels.Add(storageModel);
           
         

        }
        public static void DeleteProducts( int id)
        {
            var product= _storageModels.Where(x => x.Id == id).FirstOrDefault();
            _storageModels.Remove(product);
           

            
        }
        public static List<StorageModel> ShowProducts()
        {
            return _storageModels;

        }
        public static void EditProducts( StorageModel storageModel)
        {
           //مدیریت خطا
            var storagemodels = _storageModels.Where(x => x.Id == storageModel.Id).FirstOrDefault();
            storagemodels.Model = storageModel.Model;
            storagemodels.Color = storageModel.Color;
            storagemodels.Brands = storageModel.Brands;
            storagemodels.Groupsenum=storageModel.Groupsenum;
        
        }
        public static StorageModel DetailsProducts(int id)
        {
            var products = _storageModels.Where(x => x.Id == id).FirstOrDefault();
            return products;


        }
        public static StorageModel GetId(int id)
        {
            var idproduct= _storageModels.Where(x=>x.Id==id).FirstOrDefault();
            return idproduct;

        }
        public static string MiladiToShamsi(DateTime dateTime)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(persianCalendar.GetYear(dateTime).ToString("0000"));
            stringBuilder.Append("/");
            stringBuilder.Append(persianCalendar.GetMonth(dateTime).ToString("00"));
            stringBuilder.Append("/");
            stringBuilder.Append(persianCalendar.GetDayOfMonth(dateTime).ToString("00"));
            return stringBuilder.ToString();
        }
      








    }
}
