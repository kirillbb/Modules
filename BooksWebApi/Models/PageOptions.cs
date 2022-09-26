using Microsoft.Extensions.Options;

namespace BooksWebApi.Models
{
    public class PageOptions
    {        
        public int Page { get; set; } = 1;

        public int PageSize { get; set; } = 30;
    }
}
