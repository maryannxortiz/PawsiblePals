using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PawsiblePals.Models
{
    public class Account : IdentityUser
    {
        public ICollection<Pet> Pets { get; set; }//this holds the instance of multiple pets.
    }
}
