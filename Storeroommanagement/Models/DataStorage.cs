namespace Storeroommanagement.Models
{
    public static class DataStorage
    {
        private static List<StorageModel> storageModels = new List<StorageModel>()
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

      
        






    }
}
