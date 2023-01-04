using System.Text.Json.Serialization;

namespace InMemory.Entities
{

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [JsonIgnore]
        public Author Author { get; set; }
    }
}
