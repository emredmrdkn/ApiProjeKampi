using ApıProjeKampi.WebApi.Entities;

namespace ApıProjeKampi.WebApi.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int? CategoryId { get; set; }

        //kategori ile ilişki - kategori olmadığında hta almayacağız
        public Category Category { get; set; }

    }
}