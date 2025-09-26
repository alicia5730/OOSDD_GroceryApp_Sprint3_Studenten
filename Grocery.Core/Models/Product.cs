namespace Grocery.Core.Models
{
    public class Product : Model
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public int Stock { get; set; }
        public string Category { get; set; } = "Overig";


   
        public Product(int id, string name, int stock, string category) 
            : base(id, name)
        {
            Id = id;
            Name = name;
            Stock = stock;
            Category = category;
        }
    }
}