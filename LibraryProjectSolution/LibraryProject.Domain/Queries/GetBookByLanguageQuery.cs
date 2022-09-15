using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryProject.Domain.Responses;
using MediatR;

namespace LibraryProject.Domain.Queries
{
    public class GetBookByLanguageQuery : IRequest<BookResponse>
    {
        public string Language { get; set; }

        public GetBookByLanguageQuery(string language)
        {
            Language = language;
        }
    }
}