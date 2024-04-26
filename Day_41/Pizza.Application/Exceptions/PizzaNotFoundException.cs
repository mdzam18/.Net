namespace Pizza.Application.Exceptions
{
    public class PizzaNotFoundException : Exception
    {

        public PizzaNotFoundException(string message) : base(message) { }

    }
}
