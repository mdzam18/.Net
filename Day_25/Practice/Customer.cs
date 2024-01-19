namespace Practice
{
    class Customer
    {

        public Customer(int customerId, string customerName)
        {
            CustomerId = customerId;
            CustomerName = customerName;
        }

        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

    }
}