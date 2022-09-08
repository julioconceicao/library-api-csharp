namespace LibraryProject.Domain.Responses
{
    public class BookResponse
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public int? Year { get; set; }
        public int? PagesNumber { get; set; }
        public string? BookLanguage { get; set; }
    }
}