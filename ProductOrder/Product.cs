using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ProductOrder
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int count { get; set; }

        public Product(string name,double Price,int count)
        {
            Name= name;
            this.count = count;
            this.Price = Price;
        }

    }
}
