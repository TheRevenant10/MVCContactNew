using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ContactBOL
{
    public class ContactModel
    {
        [Required(ErrorMessage="First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage="Last Name is Required")]
        public string LastName { get; set; }

        public string FullName { get; set; }

        [Required(ErrorMessage="Company Name is required")]
        public string Company { get; set; }

        [Required(ErrorMessage="Job Title is required")]
        public string JobTitle { get; set; }
        
        [Required(ErrorMessage="Email is required")]
        public string EmailAddress { get; set; }       

        public string PhoneNumberBusiness { get; set; }

        public string PhoneNumberHome { get; set; }

        public string PhoneNumberBusinessFax { get; set; }

        public string PhoneNumberMobile { get; set; }

        public string Address { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }

        public List<Country> Countries { get; set; }
    }
}
