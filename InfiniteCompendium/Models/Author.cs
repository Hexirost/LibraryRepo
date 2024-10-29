namespace InfiniteCompendium.Models
{
    public class Author
    {
        public int ID { get; set; }
        public required string authorName { get; set; }
        public virtual ICollection<Models.Book> Book { get; set; } = new List<Book>();

    }
}
