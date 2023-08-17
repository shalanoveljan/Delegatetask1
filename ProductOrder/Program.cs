using ProductOrder;


Order order= new Order();


Product product = new Product("alma", 50, 1);
Product product1 = new Product("armud", 30, 1);
Product product2 = new Product("nar", 70, 1);

order.AddProduct(product);
order.AddProduct(product1);
order.AddProduct(product2);

order.Satish(order,(order) =>
{
    if (order.totalPrice <= 100) return order.totalPrice-(int)order.totalPrice;
    if (order.totalPrice>100 && order.totalPrice <= 200) return order.totalPrice-(int) (order.totalPrice * 10) / 100;
    return  order.totalPrice - (int)(order.totalPrice * 20) / 100;
});
Console.WriteLine(order.totalPrice);
