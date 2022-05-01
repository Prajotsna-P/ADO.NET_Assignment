using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Mvc;
using Businfo_2._3.Models;


namespace Businfo_2._3.Controllers
{
    public class BusinfoController : Controller
    {
        BusinfodbEntities db = new BusinfodbEntities();
        public ActionResult Index()
        {
            return View((from c in db.BusInfoes
                         where c.BoardingPoint == "MUM"
                         select c));
        }
    }
}