using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PawsiblePals.Models
{
    //Will create the rows of info, filled by database.
    public class Pet
    {
        public string PetName { get; set; }
        public int PetID { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Color { get; set; }
        public int Breed { get; set; }
        public bool PetFriendly { get; set; }
        public bool PeopleFriendly { get; set; }
        public char Gender { get; set; }
    }
}
