namespace InfiniteCompendium.Models
{
    public class Category
    {
        public int ID { get; set; }
        public required string CategoryName { get; set; }
        public virtual ICollection<Models.Book> Book { get; set; } = new List<Book>();

    }
}
