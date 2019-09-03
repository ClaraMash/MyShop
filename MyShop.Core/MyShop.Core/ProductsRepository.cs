using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using MyShop.Core.Models;

namespace MyShop.DataAccess.InMemory
{
    public class ProductsRepository
    {
        ObjectCache cache = MemoryCache.Default;
        List<Product> products = new List<Product>();


        public ProductsRepository()
        {
            products = cache["products"] as List<Product>;
            if (products == null)
            {
                products = new List<Product>();
            }

            public void Commit() { 
                cache["products"] = products;
               }
            public void Insert(Product p) {
                products.Add(p);
            }
             public void Update(Product product) {
                Product productsToUpdate = producta.Find(product=> product.Id == product.Id);

                if (productToUpdate != null ){
                    productsToUpdate = product;
                 }
                else {
                    throw new Exception("Product not found");
                }

             }
            public Product Find(string Id) {
            Product productsToUpdate = products.Find(product=> product.Id == product.Id);

                if (productToUpdate != null ){
                    return product;
                 }
                else {
                    throw new Exception("Product not found");
                }
            }
            public IQueryable<Product> Collection(){
                return products.AsQueryable();
            }
             
            public void Delete(string Id) {
Product productsToUpdate = product.Delete(product=> product.Id == Id);

                if (productToUpdate != null ){
                   products.Remove(ProductToDelete);
                 }
                else {
                    throw new Exception("Product not found");
                }
}
        }

    }
}
