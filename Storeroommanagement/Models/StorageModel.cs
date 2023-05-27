namespace Storeroommanagement.Models
{
    public class StorageModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public GroupsEnum.Groups Groups { get; set; }
        public BrandEnum.Brand Brand { get; set; }
    }
}
