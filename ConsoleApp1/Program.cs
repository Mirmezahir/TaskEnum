using Core.Helpers;
using Core.Helpers.Exeption;
using Core.Models;
using System.Data;
using System.Net.Http.Headers;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product ("test",12,Types.Meat);
            Product product1 = new Product("test2", 12, Types.Baker);
            Product product2 = new Product("test3", 12, Types.Baker);
            Product product3 = new Product("test4", 12, Types.Baker);
            Product product4 = new Product("test5", 12, Types.Baker);
            Store store = new Store();
            store.AddProduct (product1);
            store.AddProduct (product);
            store.AddProduct (product2);
            store.AddProduct (product3);
            store.AddProduct (product4);
            store.RemoveProductbyNo(3);
            store.Allproducts();

            bool cixis = false;
           bool deyisen = false;    
            do
            {
                Console.WriteLine("1.Add Product\n2.FilterbyNo\n3.FilterbyName");
                int giris;
                cixis =int.TryParse (Console.ReadLine(), out giris);
                switch (giris)
                { 
                    case 1: Console.Write("Mehsul adi elave edin : ");
                        string ad = Console.ReadLine();
                        Console.WriteLine("Qiymet daxil edin ");
                        int price;
                        do
                        {
                            deyisen = int.TryParse(Console.ReadLine(), out price);
                        } while (!deyisen);
                        try
                        {
                            Product product5 = new Product(ad, price, Types.Meat);
                        }
                        catch (PriceMustBeGratherThanZeroException)
                        {

                            Console.WriteLine("ERROR");
                        }



                        break;
                
                
                
                
                
                
                
                
                }









            } while (!cixis);
            
           
        }
    }
}
