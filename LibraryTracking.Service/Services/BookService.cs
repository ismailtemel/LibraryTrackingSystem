using AutoMapper;
using LibraryTracking.Core.DTOs;
using LibraryTracking.Core.Repositories;
using LibraryTracking.Core.Services;
using LibraryTracking.Core.UnitOfWork;
using SharedLibrary.Dtos;

namespace LibraryTracking.Service.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public BookService(IBookRepository bookRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<Response<BookDto>> AddAsync(BookDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<Response<IQueryable<BookDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<BookDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoDataDto>> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoDataDto>> Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
