using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrder
{
    internal class Order
    {
        public List<Product> Products { get; set; }
        public double TotalPrice { get; private set; }
        public DateTime Date { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }

        public void Sale(Func<double> method=null)
        {
            Products.ForEach(x =>
            {
                TotalPrice += x.Price*x.Count;
            });
            Console.WriteLine($"Total price without discount is: {TotalPrice}");
            method ??= ChangeTotalPrice;
            Date = DateTime.Now;
            Console.WriteLine(TotalPrice*=method());
        }

        public double ChangeTotalPrice()
        {
            if (TotalPrice < 100)
            {
                return 1;
            }
            else if (TotalPrice >= 100 && TotalPrice <= 200)
            {
                return 0.9;
            }
            else if (TotalPrice > 200 && TotalPrice <= 400)
            {
                return 0.8;
            }
            else if(TotalPrice>400 && TotalPrice<=600)
            {
                return 0.65;
            }
            else
            {
                return 0.5;
            }
        }
        
    }
    
}
