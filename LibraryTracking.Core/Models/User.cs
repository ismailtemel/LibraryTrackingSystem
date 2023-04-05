using Microsoft.AspNetCore.Identity;

namespace LibraryTracking.Core.Models
{
    public class User : IdentityUser
    {
        public int MemberShipNumber { get; set; }
    }
}
