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
        public double totalPrice
        {
            get
            {
                double total = 0;
                foreach (var item in Products)
                {
                    total = total + (item.Price * item.count);
                }
                return total;
            }
            private set { }
        }

        public DateTime date { get; set; }

        public Order()
        {
            Products = new List<Product>();
            date = DateTime.Now;

        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
           // product.count--;
        }


        public delegate double OrderDelegate(Order order);

        public void Satish(Order order, OrderDelegate orderdel)
        {

            double discountAmount = orderdel(order);
           order.totalPrice -= discountAmount;


            //}

            //public double Satish1(Order order )
            //{ 
            //      order.totalPrice = order.totalPrice + order.totalPrice * 0;

            //    return order.totalPrice;

            //}

            //public double Satish2(Order order)
            //{   
            //    order.totalPrice -= (order.totalPrice * 10) / 100;
            //    return order.totalPrice;

            //}

            //public  bool Satish3(Order order)
            //{ 
            //        order.totalPrice -= (order.totalPrice * 20) / 100;
            //        return order.totalPrice;

            //}



        }
    }
}