using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceSite.Models
{
    public class Member
    {
        //Data Annotations - Validation and DB markup
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        //int is automatically required because
        //it is a value type
        [Key] //Mark this field as PK (Primary Key)
        public int MemberId { get; set; }

        [Required]
        [DataType(DataType.Password)] //Enum/Enumeration
        public string Password { get; set; }

    }

    public class LoginViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
