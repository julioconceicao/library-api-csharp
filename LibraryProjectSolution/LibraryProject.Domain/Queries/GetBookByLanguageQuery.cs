using LibraryProject.Domain.Responses;
using MediatR;

namespace LibraryProject.Domain.Queries
{
    public class GetBookByLanguageQuery : IRequest<IEnumerable<BookResponse>>
    {
        public string BookLanguage { get; set; }

        public GetBookByLanguageQuery(string bookLanguage)
        {
            BookLanguage = bookLanguage;
        }
    }
}