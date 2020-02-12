using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PawsiblePals.Models
{
    public class Account : IdentityUser
    {
        public ICollection<Pet> Pet { get; set; }//this holds the instance of multiple pets.
    }
}
