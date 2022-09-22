namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        // Question mark means it is a nullable type. The string can be of any valid string value, plus an additional null value.
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
