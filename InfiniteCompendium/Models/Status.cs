namespace InfiniteCompendium.Models
{
    public class Status
    {
        public int ID { get; set; }
        public required string StatusName { get; set; }
        public virtual ICollection<Models.Book> Book { get; set; } = new List<Book>();
    }
}
