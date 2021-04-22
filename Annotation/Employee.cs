using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsDemo
{
    class Employee
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Employee {0} is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name should have minimum of 3 charaters and maximum 100 characters")]
        [DataType(DataType.Text)]
        public string Name { get; set; } //234567654
        [Range(18, 100, ErrorMessage = "Age should be above 18 and less than 100")]
        // [Range(18, 100, ErrorMessage = "Age should be above 18")]
        public int Age { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

    }

}
