using ContactBOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class NewContactController : Controller
    {
        //
        // GET: /NewContact/

        public ActionResult Index()
        {
            ContactModel contact = new ContactModel();

            List<ContactBOL.Country> countyList = new List<ContactBOL.Country>();
            countyList.Add(new ContactBOL.Country { ID = 1, Name = "India" });
            countyList.Add(new ContactBOL.Country { ID = 2, Name = "USA" });
            countyList.Add(new ContactBOL.Country { ID = 3, Name = "South Africa" });
            countyList.Add(new ContactBOL.Country { ID = 4, Name = "Sri Lanka" });

            contact.Countries = countyList;

            return View("NewContact",contact);
        }

        [HttpGet]
        public ActionResult SaveContact(ContactModel contact)
        {
            int x = 0;
            x /= x;
            return View();
            //List<ContactModel> list = SaveList(contact);
            //return PartialView("_NewContactDetails", list);
        }

        [NonAction]
        public List<ContactModel> SaveList(ContactModel newContact)
        {
            List<ContactModel> newList = new List<ContactModel>();
            newList.Add(newContact);
            return newList;
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;

            // Redirect on error:
            //filterContext.Result = RedirectToAction("Index", "Error");

            // OR set the result without redirection:
            filterContext.Result = new ViewResult
            {
                ViewName = "~/Views/Error.cshtml"
            };
        }
    }
}
