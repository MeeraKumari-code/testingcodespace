namespace ProductsApi.Models
{
    //create Products class with properties: Id, Name, Price, Description, Category
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price {get; set; }

        public string Brand { get; set; }
        //add Quantity property
        public int Quantity { get; set; }
    }

}
