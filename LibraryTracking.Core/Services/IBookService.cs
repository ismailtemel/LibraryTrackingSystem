using LibraryTracking.Core.DTOs;
using SharedLibrary.Dtos;

namespace LibraryTracking.Core.Services
{
    public interface IBookService
    {
        Task<Response<BookDto>> GetByIdAsync(int id);
        Task<Response<IQueryable<BookDto>>> GetAllAsync();
        Task<Response<BookDto>> AddAsync(BookDto entity);

        Task<Response<NoDataDto>> Remove(int id);

        Task<Response<NoDataDto>> Update(int id);
    }
}
