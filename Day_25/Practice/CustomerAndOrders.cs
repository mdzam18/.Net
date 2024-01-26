namespace Practice
{
    class CustomerAndOrders
    {

        public CustomerAndOrders(int orderId, DateTime date, string product, decimal price, int customerId, string customerName)
        {
            OrderId = orderId;
            Date = date;
            Product = product;
            Price = price;
            CustomerId = customerId;
            CustomerName = customerName;
        }

        public int OrderId { get; set; }

        public DateTime Date { get; set; }

        public string Product { get; set; }

        public decimal Price { get; set; }

        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

    }
}
