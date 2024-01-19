namespace Practice
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            currentDirectory = currentDirectory.Substring(0, currentDirectory.IndexOf("bin"));
            string customersFilePath = currentDirectory + "Customers.txt";
            string ordersFilePath = currentDirectory + "Orders.txt";
            OrderManager orderManager = new OrderManager(customersFilePath, ordersFilePath);
            ShowResults(orderManager.GetNumberOfOrdersForEachCustomer(), "number of orders for each customer");
            ShowResults(orderManager.GetSumPriceForEachCustomer(), "sum price for each customer");
            ShowResults(orderManager.GetMinOrderPriceForEachCustomer(), "min order price for each customer");
            ShowResults(orderManager.GetCustomersWithMoreThanOneOrder(), "customers with more than one order");
            ShowResults(orderManager.GetCustomersWithAverageOrderMoreThanPassedValue(10), "customers with average order more than passed value");
        }

        private static void ShowResults(IEnumerable<string> results, string text)
        {
            Console.WriteLine(text);
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
            Console.WriteLine();
        }

    }
}