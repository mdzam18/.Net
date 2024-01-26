namespace Geography_Now
{
    abstract class GeographicEntity
    {

        public GeographicEntity(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public abstract decimal Area { get; }

        public abstract int Population { get; }

    }
}
