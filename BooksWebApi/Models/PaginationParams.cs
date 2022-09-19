namespace BooksWebApi.Models
{
    public class PaginationParams
    {
        private const int _maxItemPerPage = 30;
        private int pageSize;
        public int Page { get; set; } = 1;
        public int PageSize 
        {
            get => pageSize; 
            set => pageSize = value > _maxItemPerPage ? _maxItemPerPage : value; 
        }
    }
}
