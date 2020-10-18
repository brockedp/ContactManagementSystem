using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace ContactApplication.Data
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(250)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }


    }
}
