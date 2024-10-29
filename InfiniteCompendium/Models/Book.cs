namespace InfiniteCompendium.Models
{
    public class Book
    {
        public int ID { get; set; }
        public required string Title { get; set; }

        //Foreign Keys
        public int AuthorID { get; set; }
        public virtual required Author  Author { get; set; }
        public int StatusId { get; set; }
        public virtual required Status Status{ get; set; }
        public int CategoryId { get; set; }
        public virtual required Category Category{ get; set; }
    }
}
