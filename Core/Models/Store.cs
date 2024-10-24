using Core.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Store
    {
        Product[] products = new Product[0];
        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);

            products[products.Length - 1] = product;
        }
        public void RemoveProductbyNo(int no)
        {
            int j=0;
            Product[] removedproducts = new Product[products.Length - 1];
            for (int i = 0; i < removedproducts.Length; i++)
            {
                if (products[i].No != no)
                {
                    j++;
                    removedproducts[j] = products[i];
                }
            }
            products = removedproducts;
        }
        public void GetProduct(int no)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].No != no)
                {
                    Console.WriteLine(products[i].Name);
                }

            }

        }
        public void FilterProductsByType(Types types)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (types.ToString().ToLower() == products[i].Type.ToLower())
                {
                    Console.WriteLine(products[i].Type + " " + products[i].Name);
                }
            }
        }
        public void FilterProductByName(string name)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Name.ToLower() == name.ToLower())
                {
                    Console.WriteLine(products[i].Name);
                }
            }
        }
        public void Allproducts()
        {

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] != null)
                {
                    Console.WriteLine(products[i].Name);
                }

            }


        }
    }
}
