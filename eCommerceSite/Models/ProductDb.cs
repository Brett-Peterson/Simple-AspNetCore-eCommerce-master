using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceSite.Models
{
    public static class ProductDb
    {
        public static Product Add(Product p, CommerceContext db)
        {
            db.Products.Add(p);
            db.SaveChanges();
            return p;
        }

        public static List<Product> GetProducts(CommerceContext context)
        {
            //LINQ Query Syntax
            return (from p in context.Products
                    select p).ToList();

            //LINQ Method Syntax
            //return context.Products.ToList();
        }

        public static Product GetProduct(CommerceContext context, int id)
        {
            //LINQ method syntax - grab product by id
            Product p2 = context
                            .Products
                            .Where(product => product.ProductId == id)
                            .Single();
            return p2;

            //LINQ query syntax - Grabbing a single product by id
            Product p = (from prods in context.Products
                         where prods.ProductId == id
                         select prods).Single();

            return p;
        }
    }
}
