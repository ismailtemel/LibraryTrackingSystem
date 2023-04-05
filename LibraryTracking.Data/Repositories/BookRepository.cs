using LibraryTracking.Core.Models;
using LibraryTracking.Core.Repositories;

namespace LibraryTracking.Data.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(AppDbContext context) : base(context)
        {
        }
    }
}
