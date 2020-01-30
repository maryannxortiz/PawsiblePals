using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PawsiblePals.Models
{
    public class Account : IdentityUser
    {

        public int accountID { get; set; }
        public string email { get; set; }
        public string password { get; set; }

    }
}
