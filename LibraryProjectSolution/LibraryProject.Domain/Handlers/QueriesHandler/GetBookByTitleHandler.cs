using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace LibraryProject.Domain.Handlers.QueriesHandler
{
    public class GetBookByTitleHandler : IRequestHandler<GetBookByTitleQuery, BookResponse>
    {
        
    }
}