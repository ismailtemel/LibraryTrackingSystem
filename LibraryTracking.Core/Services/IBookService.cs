using LibraryTracking.Core.DTOs;
using LibraryTracking.Core.Models;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
