using Core.Helpers;
using Core.Helpers.Exeption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Product
    {
        public string Name { get; set; }
        private static int _no;
        private int _price;

        public Product(string name, int price, Types types)
        {
            Name = name;
            Price = price;
            Type = types.ToString();
            ++_no;
            No=_no;
        }

        public int No { get; }
        public int Price {

            get
            {

                return _price;
            }



            set
            {
                if (value > 0) { _price = value; }
                else
                {
                    throw new PriceMustBeGratherThanZeroException("Qiymet sifirdan boyuk olmalidir ");
                }
            }

        }
        public string Type { get; set; }
       
    }
        


    
}
