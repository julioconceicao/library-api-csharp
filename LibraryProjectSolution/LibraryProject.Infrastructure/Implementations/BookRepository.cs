using Microsoft.EntityFrameworkCore;
using LibraryProject.Core;
using LibraryProject.Domain.Interfaces;

namespace LibraryProject.Infrastructure.Implementations
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDBContext _context;

        public BookRepository(LibraryDBContext context)
        {
            _context = context;
        }

        public async Task Add(BookModel entity)
        {
            await _context.Books.AddAsync(new BookModel
            {
                Title = entity.Title,
                Author = entity.Author,
                Genre = entity.Genre,
                Year = entity.Year,
                PagesNumber = entity.PagesNumber,
                BookLanguage = entity.BookLanguage
            });
            await _context.SaveChangesAsync();
        }

        public async Task<BookModel> FindById(Guid id)
        {
            return await _context.Books
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task Update(BookModel entity)
        {
            var Book = await FindById(entity.Id);
            Book.Title = entity.Title;
            Book.Author = entity.Author;
            Book.Genre = entity.Genre;
            Book.Year = entity.Year;
            Book.PagesNumber = entity.PagesNumber;
            Book.BookLanguage = entity.BookLanguage;
            _context.Books.Update(Book);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            _context.Remove(await FindById(id));
            await _context.SaveChangesAsync();
        }

        public async Task<BookModel> FindByTitle(string title)
        {
            return await _context.Books
                .FirstOrDefaultAsync(b => b.Title == title);
        }

        public async Task<IEnumerable<BookModel>> FindByLanguage(string bookLanguage)
        {
            return await _context.Books
            .Where(b => b.BookLanguage.Contains(bookLanguage))
                .ToListAsync();
        }
    }
}