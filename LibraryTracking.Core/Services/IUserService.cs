using LibraryTracking.Core.DTOs;
using SharedLibrary.Dtos;

namespace LibraryTracking.Core.Services
{
    public interface IUserService
    {
        Task<Response<UserDto>> CreateUserAsync(CreateUserDto createUserDto);
        Task<Response<UserDto>> GetUserByNameAsync(string userName);
        Task<Response<NoDataDto>> CreateUserRoles(string userName, string role);
    }
}
