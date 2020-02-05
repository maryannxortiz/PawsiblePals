using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PawsiblePals.Models
{
    public class User : IdentityUser
    {
        public int UserID { get; set; }
        public Pet Pet { get; set; }//this holds the instance of the pet.
    }
}
