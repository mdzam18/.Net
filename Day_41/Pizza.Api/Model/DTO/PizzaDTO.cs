namespace Pizza.Api.Model.DTO
{
    public class PizzaDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public decimal CaloryCount { get; set; }
    }
}
