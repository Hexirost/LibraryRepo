namespace InfiniteCompendium.Models
{
    public class Books
    {
        public int ID { get; set; }
        public required string Title { get; set; }
        public string? Author { get; set; }
        public required bool status{ get; set; }
        public string? Category {  get; set; }
    }
}
