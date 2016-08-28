using ContactBOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactBAL;

namespace MvcApplication1.Controllers
{
    public class ContactFormController : Controller
    {
        //
        // GET: /ContactForm/

        ContactBAL.ContactBAL objContactBusiness = new ContactBAL.ContactBAL();

        public ActionResult Index()
        {
            ContactModel contact = new ContactModel();
            contact.Countries = objContactBusiness.GetCountries();
            return View("ContactForm",contact);
        }

        [HttpGet]
        public ActionResult SaveContact(ContactModel contact)
        {
            contact.FullName = contact.FirstName + " " + contact.LastName;
            List<ContactModel> list = objContactBusiness.SaveContact(contact); 
            return PartialView("_NewContactFormDetails", list);    
        }
      
    }
}
