using JMA_Tech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JMA_Tech.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            JMAEntities jma = new JMAEntities();
            return View( jma.tblCustomer_JMA.ToList());
        }
       
    }
}