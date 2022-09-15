using LibraryProject.Domain.Responses;
using MediatR;

namespace LibraryProject.Domain.Commands
{
    public class CreateBookRequest : IRequest<BookResponse>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public int PagesNumber { get; set; }
        public string BookLanguage { get; set; }
    }
}