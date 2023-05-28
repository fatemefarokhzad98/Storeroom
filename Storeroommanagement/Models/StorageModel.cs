using static Storeroommanagement.Enum.Brands;
using static Storeroommanagement.Enum.Groups;

namespace Storeroommanagement.Models
{
    public class StorageModel
    {
      
        public int Id { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public GroupsEnum Groupsenum { get; set; }
        public BrandEnum Brands { get; set; }
       
    }
}
