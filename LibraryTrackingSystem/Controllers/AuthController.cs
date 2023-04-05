using LibraryTracking.Core.DTOs;
using LibraryTracking.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryTrackingSystem.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : CustomBaseController
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateToken(LoginDto loginDto)
        {
            return ActionResultInstance(await _authenticationService.CreateTokenAsync(loginDto));
        }

        [HttpPost]
        public async Task<IActionResult> CreateTokenByRefreshToken(RefreshTokenDto refreshTokenDto)
        {
            return ActionResultInstance(await _authenticationService.CreateTokenByRefreshToken(refreshTokenDto.Token));
        }


        [HttpPost]
        public async Task<IActionResult> RevokeRefreshToken(RefreshTokenDto refreshTokenDto)
        {
            return ActionResultInstance(await _authenticationService.RevokeRefreshToken(refreshTokenDto.Token));
        }
    }
}
