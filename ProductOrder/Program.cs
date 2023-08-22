using ProductOrder;


Product product1 = new Product("Monitor", 100, 4);
Product product2 = new Product("Mouse", 50, 5);
Product product3 = new Product("Keyboard", 70, 3);

List<Product> products = new List<Product>()
{
    product1,
    product2,
    product3
};


Order order = new Order();
order.Products = products;

order.Sale();
