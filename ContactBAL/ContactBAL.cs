using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactBOL;
using ContactDAL;

namespace ContactBAL
{
    public class ContactBAL
    {
        ContactDAL.ContactDAL objContact = new ContactDAL.ContactDAL();

        public List<Country> GetCountries()
        {
            return objContact.GetCountryList();
        }

        public List<ContactModel> SaveContact(ContactModel contact)
        {
            return objContact.SaveContact(contact);
        }
    }
}
