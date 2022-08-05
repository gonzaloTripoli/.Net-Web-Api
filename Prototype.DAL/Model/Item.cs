namespace PrototypeApp.DAL.Model
{
    public class Item : EntityBase
    {
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
