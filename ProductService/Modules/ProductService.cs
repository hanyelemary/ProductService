using System;
using System.Collections;
using System.Collections.Generic;
using Nancy;
using ProductService.Model;

namespace ProductService.Modules
{
    public class ProductService : NancyModule
    {
        public ProductService() : base("/products")
        {
            Get["/"] = _ =>
            {
                List<Product> products = new List<Product>();
                products.Add(new Product()
                {
                    Id = 1,
                    description = "Delicious oatmeal",
                    name = "Oatmeal"
                });
                products.Add(new Product()
                {
                    Id = 2,
                    description = "Muscle milk",
                    name = "Awesome Brand Muscle Milk"
                });
                
                return products;
            };

            Get["/{id}"] = parameters => String.Format("Product with id {0}", parameters.id);
        }
    }
}