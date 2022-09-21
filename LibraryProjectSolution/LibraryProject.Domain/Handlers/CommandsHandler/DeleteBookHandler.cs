using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LibraryProject.Domain.Commands;
using LibraryProject.Domain.Interfaces;
using MediatR;

namespace LibraryProject.Domain.Handlers.CommandsHandler
{
    public class DeleteBookHandler : IRequestHandler<DeleteBookRequest, object>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public DeleteBookHandler(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;

        }
        public async Task<object> Handle(DeleteBookRequest request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.FindById(request.Id);

            if (book == null)
            {
                throw new DllNotFoundException($"Could not find this book. Id:{request.Id}");
            }
            await _bookRepository.Delete(book.Id);
            return (new object[]
            {
                $"Delete user {request.Id}",
            });
        }
    }
}