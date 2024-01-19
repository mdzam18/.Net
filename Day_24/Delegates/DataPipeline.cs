namespace Delegates
{
    class DataPipeline<T>
    {

        public Predicate<T> FilterDelegate { get; set; }

        public Func<T, BookDto> TransformDelegates { get; set; }

        public DataPipeline(Predicate<T> fillter, Func<T, BookDto> transform)
        {
            FilterDelegate += fillter;
            TransformDelegates += transform;
        }

        public List<BookDto> Process(IEnumerable<T> input)
        {
            List<BookDto> result = new List<BookDto>();
            foreach (var item in input)
            {
                if (FilterDelegate(item))
                {
                    result.Add(TransformDelegates(item));
                }
            }
            return result;
        }

    }
}