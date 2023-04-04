using LibraryTracking.Core.Repositories;
using LibraryTracking.Core.Services;
using LibraryTracking.Core.UnitOfWork;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTracking.Service.Services
{
    public class ServiceGeneric<T,TDto> : IServiceGeneric<T,TDto> where T : class where TDto : class
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IGenericRepository<T> _genericRepository;

        public ServiceGeneric(IUnitOfWork unitOfWork, IGenericRepository<T> genericRepository)
        {
            _genericRepository = genericRepository;
            _unitOfWork = unitOfWork;
        }

        public Task<Response<TDto>> AddAsync(TDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<Response<IQueryable<TDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Response<TDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoDataDto>> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoDataDto>> Update(TDto entity, int id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<IEnumerable<TDto>>> Where(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
