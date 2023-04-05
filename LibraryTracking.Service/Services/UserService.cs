using AutoMapper;
using LibraryTracking.Core.DTOs;
using LibraryTracking.Core.Models;
using LibraryTracking.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using SharedLibrary.Dtos;

namespace LibraryTracking.Service.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;

        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly IMapper _mapper;

        public UserService(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }

        public async Task<Response<UserDto>> CreateUserAsync(CreateUserDto createUserDto)
        {
            var user = new User { Email = createUserDto.Email, UserName = createUserDto.UserName };

            var result = await _userManager.CreateAsync(user, createUserDto.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description).FirstOrDefault();

                return Response<UserDto>.Fail(new ErrorDto(errors, true), 400);
            }
            return new Response<UserDto>() { Data = _mapper.Map<UserDto>(user) };
        }

        public async Task<Response<NoDataDto>> CreateUserRoles(string userName, string role)
        {
            if (!await _roleManager.RoleExistsAsync("admin"))
            {
                await _roleManager.CreateAsync(new() { Name = $"{role}" });
            }

            var user = await _userManager.FindByNameAsync(userName);
            await _userManager.AddToRoleAsync(user, $"{role}");

            return Response<NoDataDto>.Success(StatusCodes.Status201Created);
        }

        public async Task<Response<UserDto>> GetUserByNameAsync(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);

            if (user == null)
            {
                return Response<UserDto>.Fail("UserName not found", 404, true);
            }

            return new Response<UserDto>() { Data = _mapper.Map<UserDto>(user) };
        }
    }
}
