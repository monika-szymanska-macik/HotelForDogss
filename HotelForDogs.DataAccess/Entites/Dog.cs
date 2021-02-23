using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelForDogs.DataAccess.Entites
{
    public class Dog : EntityBase
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Breed { get; set; }

        [Required]
        public int Weight { get; set; }
    }
}
