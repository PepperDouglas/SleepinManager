using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepinManager.Entities
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Required, StringLength(20)]
        public string FirstName { get; set; }
        [Required, StringLength(30)]
        public string SurName { get; set; }
        [StringLength(60)]
        public string Email { get; set; }
        [StringLength(18)]
        public string Telephone { get; set; }
        [Required,StringLength(20)]
        public string Nationality { get; set; }
        
        //The NationalIdentifier could be either a personal number issued by the state or a passport number,
        //and is used for security purposes
        [Required, StringLength(18)]
        public string National_Identifier { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }


        public override string ToString() {
            return $"{FirstName} {SurName}";
        }
    }
}
