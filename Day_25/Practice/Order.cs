namespace Practice
{
    class Order
    {

        public Order(int orderId, DateTime date, string product, decimal price, int customerId)
        {
            OrderId = orderId;
            Date = date;
            Product = product;
            Price = price;
            CustomerId = customerId;
        }

        public int OrderId { get; set; }

        public DateTime Date { get; set; }

        public string Product { get; set; }

        public decimal Price { get; set; }

        public int CustomerId { get; set; }

    }
}