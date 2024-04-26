namespace ToDo.Api.Model.DTO
{
    public class BaseEntityDTO
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }

        public string Status { get; set; }
    }
}