using LibraryProject.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Domain.Interfaces.Implementations
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDBContext _context;

        public BookRepository(LibraryDBContext context)
        {
            _context = context;
        }

        // public async Task CreateBookAsync(BookModel book)
        // {
        //     await _context.Books.AddAsync(new BookModel
        //     {
        //         Title = book.Title,
        //         Author = book.Author,
        //         Genre = book.Genre,
        //         Year = book.Year,
        //         PagesNumber = book.PagesNumber,
        //         BookLanguage = book.BookLanguage
        //     });
        //     await _context.SaveChangesAsync();
        // }

        public async Task Add(BookModel entity)
        {
            await _context.Books.AddAsync(new BookModel
            {
                Title = entity.Title,
                Genre = entity.Genre,
                Year = entity.Year,
                PagesNumber = entity.PagesNumber,
                BookLanguage = entity.BookLanguage
            });
        }

        public async Task<BookModel> FindById(Guid id)
        {
            return await _context.Books
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        public Task Update(BookModel entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(BookModel entity)
        {
            throw new NotImplementedException();
        }
    }
}