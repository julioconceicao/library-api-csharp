using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Domain.Commands;
using LibraryProject.Domain.Responses;
using MediatR;

namespace LibraryProject.Domain.Handlers.CommandsHandler
{
    public class UpdateBookHandler : IRequestHandler<UpdateBookRequest, BookResponse>
    {
        public Task<BookResponse> Handle(UpdateBookRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}