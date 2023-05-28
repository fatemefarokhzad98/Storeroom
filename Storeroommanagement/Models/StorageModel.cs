namespace Storeroommanagement.Models
{
    public class StorageModel
    {
      
        public int Id { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public Groups Groupsenum { get; set; }
        public Brand Brands { get; set; }
        public enum Groups
        {
            LopTop = 1,
            Mobile

        }
        public enum Brand
        {
            Huawi = 1,
            Samsung,
            Lenovo,
            Asus
        }
    }
}
