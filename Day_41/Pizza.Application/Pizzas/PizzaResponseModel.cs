namespace Pizza.Application.Pizzas
{
    public class PizzaResponseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal CaloryCount { get; set; }
    }
}
