using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pass_data_from_view_to_controller.Models;

namespace Pass_data_from_view_to_controller.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string PostUsingParameters(string firstName, string lastName) {


            return "   PostUsingParameters  ------------------>   " + "firstName  :-  " + firstName + "  lastName  :- " + lastName;
        }

        [HttpPost]
        public string PostUsingRequest()
        {
            string firstName = Request["firstName"];
            string lastName = Request["lastName"];
            
            return "   PostUsingRequest  ------------------>   " + "firstName  :-  " + firstName + "  lastName  :- " + lastName;

        }



        public string PostUsingFormCollection(FormCollection form)
        {
            string firstName = form["firstName"];
            string lastName = form["lastName"];

            return "   PostUsingFormCollection  ------------------>   " + "firstName  :-  " + firstName + "  lastName  :- " + lastName;

        }


        [HttpPost]
        public string PostUsingBinding(Employee emp)
        {
           

            return "   PostUsingBinding  ------------------>   " + "firstName  :-  " + emp.firstName + "  lastName  :- " + emp.lastName;

        }






    }
}