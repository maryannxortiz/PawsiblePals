using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PawsiblePals.Models
{
    //Will create the rows of info, filled by database.
    public class Pet
    {
        [Key]
        public int PetID { get; set; }
        public string PetName { get; set; }
        //public int Species
        //{
        //    switch(Species)
        //    {
        //    case 'Dog': return
        //    break;
        //    case 'Cat': return;
        //    break;
        //    }


        //}

        public int Species { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Color { get; set; }
        public int Breed { get; set; }
        public bool PetFriendly { get; set; }
        public bool PeopleFriendly { get; set; }
        public char Gender { get; set; }

        
    }


    //public class dog
    //{
    //    readonly int Species = 1;
    //}
    //public class cat
    //{
    //    readonly int Species = 2;
    //}
}
