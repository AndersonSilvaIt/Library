namespace BooksAPI.ViewModels
{
    public class BookViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
    }
}
