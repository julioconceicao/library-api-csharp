using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Domain.Responses;
using MediatR;

namespace LibraryProject.Domain.Queries
{
    public class GetBookByTitleQuery : IRequest<BookResponse>
    {
        public string Title { get; set; }

        public GetBookByTitleQuery(string title)
        {
            Title = title;
        }
    }
}