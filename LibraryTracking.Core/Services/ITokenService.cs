using LibraryTracking.Core.DTOs;
using LibraryTracking.Core.Models;

namespace LibraryTracking.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(User user);
    }
}
