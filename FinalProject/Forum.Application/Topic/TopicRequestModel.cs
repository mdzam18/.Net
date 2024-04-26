using Forum.Domain.Topics;
using System.Text.Json.Serialization;

namespace Forum.Application.Topics
{
    public class TopicRequestModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreateDate { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Status Status { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public State State { get; set; }
    }
}
