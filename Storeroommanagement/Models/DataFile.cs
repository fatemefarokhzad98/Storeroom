using Newtonsoft.Json;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace Storeroommanagement.Models
{
    public static class DataFile
    {

        static private string _path= @"D:\proje.me\Storeroommanagement\.vs\Storeroommanagement\Product.txt";
        static private string _pathtime = @"D:\proje.me\Storeroommanagement\.vs\Storeroommanagement\Producttime.txt";
        public static void AddProducts(StorageModel storageModel)
        {
            
            var products = ShowProduct();
            if (products.Count==0)
            {
                storageModel.Id = 1;

            }
            else
            {
                storageModel.Id = products.Last().Id + 1;
            }
            var userjson = JsonConvert.SerializeObject(storageModel);
            File.AppendAllText(_path, userjson+"\n");
           AddTime(storageModel.Id, MiladiToShamsi(DateTime.Now));

        }
        public static List<StorageModel> ShowProduct()
        {
           var result=new List<StorageModel>();
            try
            {
                var Products = File.ReadAllText(_path);
                var UserJson = Products.Split("\n").ToList();
               UserJson.Remove (UserJson.Last());
            foreach (var Product in UserJson)
                {
                    var jsonuser = JsonConvert.DeserializeObject<StorageModel>(Product);

                    result.Add(jsonuser);

                }


            }
            catch (Exception)
            {

                return new List<StorageModel> ();
            }



            return result.Where(x => x.IsDelete == false)
                .ToList();


        }
        public static bool DeletProduct(int id)
        {
            
            var products = ShowProduct();
            var product = products.Where(x => x.Id ==id)
                .FirstOrDefault();
            if (product != null)
            {
                
                File.Delete(_path);
               
                foreach (var item in products)
                {
                    item.IsDelete = true;
                    var userjson = JsonConvert.SerializeObject(item);
                    File.AppendAllText(_path, userjson + "\n");

                }

                DeleteTime(id, MiladiToShamsi(DateTime.Now));
                return true;


            }
            return false;
        }
        public static  void EditProduct( StorageModel storageModel)
        {

            var Products=ShowProduct();
            var product = Products.Where(x => x.Id == storageModel.Id)
                .FirstOrDefault();
            if (product!=null)
            {
                product.Brands = storageModel.Brands;
                product.Color = storageModel.Color;
                product.Groupsenum = storageModel.Groupsenum;
                product.Model = storageModel.Model;
                

                File.Delete(_path);
                foreach (var item in Products)
                {
                    var jsonuser = JsonConvert.SerializeObject(item);
                    File.AppendAllText(_path,jsonuser+ "\n");
                }
              

            }
            else
            {
                ShowProduct();
            }

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
        public static void AddTime(int id,string createtime)
        {
            var timesadd= ShowTimeProduct();
            var timeadd = timesadd.Where(x => x.Id == id).FirstOrDefault();
            if (timeadd != null)
            {
                timeadd.AddTimes = createtime;

               var jsonuser= JsonConvert.SerializeObject(timeadd);
                File.AppendAllText(_pathtime,jsonuser+ "\n");
            }

        }
        public static void DeleteTime(int id, string deletetime)
        {
            var timesdelete = ShowTimeProduct();
            var timedelete= timesdelete.Where(x => x.Id == id).FirstOrDefault();
            if (timedelete != null)
            {
                timedelete.DeleteTimes = deletetime;
                 var jsonuser = JsonConvert.SerializeObject(timedelete);
                File.AppendAllText(_pathtime, jsonuser + "\n");
            }

        }

        public static List<TimeProduct> ShowTimeProduct()
        {
            var Result = new List<TimeProduct>();
            try
            {
                var timetxts = File.ReadAllText(_pathtime);
                var timetextstring = timetxts.Split("\n").ToList();
              timetextstring.Remove(timetextstring.Last());
                foreach (var time in timetextstring)
                {
                    var listuser = JsonConvert.DeserializeObject < TimeProduct >(time);

                    Result.Add(listuser);
                  
                }
                




            }
            catch (Exception)
            {

                return new List<TimeProduct>();

                
            }
            return Result;

        }
        public static StorageModel GetId(int id)
        {
            var products = ShowProduct();
            var product = products.Where(x => x.Id == id).FirstOrDefault();
            return product;


        }



    }
}
