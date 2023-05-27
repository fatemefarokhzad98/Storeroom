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
                Brand=BrandEnum.Brand.Asus,
                Groups=GroupsEnum.Groups.LopTop


            },
             new StorageModel()

            {
                Id=2,
                Model="A30",
                Color="green",
                Brand=BrandEnum.Brand.Samsung,
                Groups=GroupsEnum.Groups.Mobile


            },
              new StorageModel()

            {
                Id=3,
                Model="A50",
                Color="blue",
                Brand=BrandEnum.Brand.Lenovo,
                Groups=GroupsEnum.Groups.LopTop


            },
                  new StorageModel()

            {
                Id=4,
                Model="A70",
                Color="yellow",
                Brand=BrandEnum.Brand.Huawi,
                Groups=GroupsEnum.Groups.Mobile


            },




        };
        public static void AddProducts( StorageModel storageModel)
        {//اینجا راه های دیگش که از خطا جلوگیری میکنه چیه
            storageModel.Id = _storageModels.Last().Id + 1;
            _storageModels.Add(storageModel);

        }
        public static StorageModel DeleteProducts( StorageModel storageModel)
        {
            var products = _storageModels.Where(x => x.Id == storageModel.Id).FirstOrDefault();
            _storageModels.Remove(products);

            return products;
        }
        public static List<StorageModel> ShowProducts()
        {
            return _storageModels;

        }
        public static void EditProducts( StorageModel storageModel)
        {
            //var storagemodels = _storageModels.Where(x => x.Id == storageModel.Id).FirstOrDefault();
            //if (storagemodels != null)
            //{
            //    storagemodels.Model = storageModel.Model;
            //    storagemodels.Brand = storageModel.Brand;
            //    storagemodels.Groups = storageModel.Groups;
            //    storagemodels.Color = storageModel.Color;

            //}
            //else
            //{
            //    AddProducts();
            //}
            var storagemodels = _storageModels.Where(x => x.Id == storageModel.Id).FirstOrDefault();
            storagemodels.Model = storageModel.Model;
              storagemodels.Brand = storageModel.Brand;
              storagemodels.Groups = storageModel.Groups;
               storagemodels.Color = storageModel.Color;
        }
        public static StorageModel DetailsProducts(int id)
        {
            var products = _storageModels.Where(x => x.Id == id).FirstOrDefault();
            return products;


        }










    }
}
