using System.Collections.Generic;
using System.Linq;

namespace DemoITI.Models
{
    public class ProductSampleDate
    {
        List<Product> Products = new List<Product>();
        public ProductSampleDate() {
            Products.Add(
                new Product() { Id = 1 , Name = "Iphone" , Price = 3000 , Description = "Excellent Iphone" , Image = "1.jpg"}
            );
            Products.Add(
                new Product() { Id = 2, Name = "Iphone2", Price = 13000, Description = "Excellent Iphone", Image = "2.jpg" }
            );
            Products.Add(
                new Product() { Id = 3, Name = "Iphone3", Price = 23000, Description = "Excellent Iphone", Image = "3.jpg" }
            );
            Products.Add(
                new Product() { Id = 4, Name = "Iphone4", Price = 33000, Description = "Excellent Iphone", Image = "4.jpg" }
            );
        }

        public List<Product> GetAll()
        {
            return Products;
        }

        public Product GetById(int id)
        {
            Product product = Products.FirstOrDefault<Product>(P => P.Id == id);
            return product;
        }

    }
}
