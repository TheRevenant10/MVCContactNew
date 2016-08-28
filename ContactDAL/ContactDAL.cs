using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactBOL;

namespace ContactDAL
{
    public class ContactDAL
    {
        public List<Country> GetCountryList()
        {
            List<Country> countyList = new List<Country>();
            countyList.Add(new Country { ID = 1, Name = "India" });
            countyList.Add(new Country { ID = 2, Name = "USA" });
            countyList.Add(new Country { ID = 3, Name = "South Africa" });
            countyList.Add(new Country { ID = 4, Name = "Sri Lanka" });

            return countyList;
        }

        public List<ContactModel> SaveContact(ContactModel newContact)
        {
            List<ContactModel> newList = new List<ContactModel>();
            newList.Add(newContact);
            return newList;
        }
    }
}
