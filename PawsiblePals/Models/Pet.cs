using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using PawsiblePals.Models;
using PawsiblePals.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace PawsiblePals.Models
{
    //Will create the rows of info, filled by database.
    public class Pet
    {

        public int PetID { get; set; }
        public string PetName { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
        public string Breed { get; set; }
        public bool PetFriendly { get; set; }
        public bool PeopleFriendly { get; set; }
        public bool Neutered { get; set; }
        public char Gender { get; set; }
        public string AccountID { get; set; }
        [ForeignKey("AccountID")]

        public Account Account { get; set; }

    }


}
