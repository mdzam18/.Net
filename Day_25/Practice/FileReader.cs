namespace Practice
{
    static class FileReader
    {

        public static List<Customer> FillCustomersList(string path)
        {
            List<Customer> result = new List<Customer>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var list = line.Split('|');
                    Customer customer = new Customer(int.Parse(list[0]), list[1]);
                    result.Add(customer);
                }
            }
            return result;
        }

        public static List<Order> FillOrderssList(string path)
        {
            List<Order> result = new List<Order>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var list = line.Split('|');
                    string date = list[1];
                    int year = int.Parse(date.Substring(0, 4));
                    int month = int.Parse(date.Substring(4, 2));
                    int day = int.Parse((date.Substring(6, 2)));
                    Order order = new Order(int.Parse(list[0]), new DateTime(year, month, day), list[2], decimal.Parse(list[3]), int.Parse(list[4]));
                    result.Add(order);
                }
            }
            return result;
        }

    }
}
