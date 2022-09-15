using LibraryProject.Domain.Responses;
using MediatR;

namespace LibraryProject.Domain.Queries
{
    public class GetBookByIdQuery : IRequest<BookResponse>
    {
        public Guid Id { get; set; }

        public GetBookByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}