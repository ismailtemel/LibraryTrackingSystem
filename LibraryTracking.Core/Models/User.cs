using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTracking.Core.Models
{
    public class User : IdentityUser
    {
        public int MemberShipNumber { get; set; }
    }
}
