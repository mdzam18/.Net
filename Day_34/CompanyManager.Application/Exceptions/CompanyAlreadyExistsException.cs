namespace CompanyManagement.Application.Exceptions
{
    public class CompanyAlreadyExistsException : Exception
    {
        public string Code = "CompanyAlreadyExists";

        public CompanyAlreadyExistsException (string message) : base(message) {}

    }
}