namespace TestingTime
{
    class SelectedIncorrectLetterException : Exception
    {

        public SelectedIncorrectLetterException() : base("Incorrect letter is selected. letter must be from 'a' to 'd'.") { }
    
    }
}