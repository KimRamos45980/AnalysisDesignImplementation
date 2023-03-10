using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignImplementation
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [StringLength(5, MinimumLength = 5)]
        public string ZipCode { get; set; }

        public string PhoneNumber { get; set; }
    }
}
