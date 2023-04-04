using LibraryTracking.Core.DTOs;
using LibraryTracking.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTracking.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(User user);
    }
}
