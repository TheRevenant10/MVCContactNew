using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactBOL;

namespace MvcApplication1.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
        {
            ContactModel contact = new ContactModel();

            List<ContactBOL.Country> countyList = new List<ContactBOL.Country>();
            countyList.Add(new ContactBOL.Country { ID = 1, Name = "India" });
            countyList.Add(new ContactBOL.Country { ID = 2, Name = "USA" });
            countyList.Add(new ContactBOL.Country { ID = 3, Name = "South Africa" });
            countyList.Add(new ContactBOL.Country { ID = 4, Name = "Sri Lanka" });

            contact.Countries = countyList;

            return View("Contact",contact);
        }

        [HttpGet]
        public ActionResult SaveContact(ContactModel contact)
        {
            List<ContactModel> list = SaveList(contact);
            return PartialView("_ContactDetails", list);
        }

        [NonAction]
        public List<ContactModel> SaveList(ContactModel newContact)
        {
            List<ContactModel> newList = new List<ContactModel>();
            newList.Add(newContact);
            return newList;
        }

    }
}
