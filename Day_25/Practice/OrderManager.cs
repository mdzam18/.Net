namespace Practice
{
    class OrderManager
    {

        List<Order> _Orders;
        List<Customer> _Customers;
        IEnumerable<CustomerAndOrders> _CustomersAndOrdersJoined;

        public OrderManager(string customersFilePath, string ordersFilePath)
        {
            _Customers = FileReader.FillCustomersList(customersFilePath);
            _Orders = FileReader.FillOrderssList(ordersFilePath);

            _CustomersAndOrdersJoined = _Customers.Join(_Orders,
           c => c.CustomerId,
           o => o.CustomerId,
           (c, o) => new CustomerAndOrders(o.OrderId, o.Date, o.Product, o.Price, o.CustomerId, c.CustomerName));
        }

        public IEnumerable<string> GetNumberOfOrdersForEachCustomer()
        {
            var result = _CustomersAndOrdersJoined.GroupBy(c => c.CustomerId).Select(g => string.Format("CustomerId - {0}, OrderCount - {1}", g.Key, g.Count()));
            return result;
        }

        public IEnumerable<string> GetSumPriceForEachCustomer()
        {
            var result = _CustomersAndOrdersJoined.GroupBy(c => c.CustomerId).Select(g => string.Format("CustomerId - {0}, SumAmount - {1}", g.Key, g.Sum(order => order.Price)));
            return result;
        }

        public IEnumerable<string> GetMinOrderPriceForEachCustomer()
        {
            var result = _CustomersAndOrdersJoined.GroupBy(c => c.CustomerId).Select(g => string.Format("CustomerId - {0}, MinAmount - {1}", g.Key, g.Min(order => order.Price)));
            return result;
        }

        public IEnumerable<string> GetCustomersWithMoreThanOneOrder()
        {
            var result = _CustomersAndOrdersJoined.GroupBy(c => c.CustomerId).Where(g => g.Count() > 1).Select(g => string.Format("CustomerId - {0}, OrderCount - {1}", g.Key, g.Count()));
            return result;
        }

        public IEnumerable<string> GetCustomersWithAverageOrderMoreThanPassedValue(decimal price)
        {
            var result = _CustomersAndOrdersJoined.GroupBy(c => c.CustomerId).Select(g => String.Format("CustomerId - {0}, AvgAmount - {1}", g.Key, g.Where(order => order.Price > price).Any() ? g.Average(order => order.Price) : 0));
            return result;
        }

    }
}