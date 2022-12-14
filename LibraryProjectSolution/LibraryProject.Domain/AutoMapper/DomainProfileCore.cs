using AutoMapper;
using LibraryProject.Domain.Commands;
using LibraryProject.Domain.Responses;
using LibraryProject.Core;

namespace LibraryProject.Domain.AutoMapper
{
    public class DomainProfileCore : Profile
    {
        public DomainProfileCore()
        {
            ClientMap();
        }

        public void ClientMap()
        {
            CreateMap<CreateBookRequest, BookModel>();
            CreateMap<BookModel, BookResponse>();
        }

    }
}