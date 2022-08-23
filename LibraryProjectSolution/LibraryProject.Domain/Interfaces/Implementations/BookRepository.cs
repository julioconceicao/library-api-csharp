using LibraryProject.Infrastructure;

namespace LibraryProject.Domain.Interfaces.Implementations
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDBContext _context;

        public BookRepository(LibraryDBContext context)
        {
            _context = context;
        }

        public async Task CreateBookAsync(BookModel book)
        {
            await _context.Books.AddAsync(new BookModel
            {
                Title = book.Title,
                Author = book.Author,
                Genre = book.Genre,
                Year = book.Year,
                PagesNumber = book.PagesNumber,
                BookLanguage = book.BookLanguage
            });
            await _context.SaveChangesAsync();
        }
    }
}