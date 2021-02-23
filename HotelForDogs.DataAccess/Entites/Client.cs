using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelForDogs.DataAccess.Entites
{
    public class Client : EntityBase
    {

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        private string _lastName { get; set; }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        [Required]
        public string PhoneNumber { get; set; }

        public List<Dog> Dogs { get; set; }
    }
}
