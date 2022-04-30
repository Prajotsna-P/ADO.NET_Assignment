using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FootballDbFirst.Models;
using System.Data;

namespace FootballDbFirst.Controllers
{
    public class FootballController : Controller
    {
        // GET: Football
        FootballDbEntities Context = new FootballDbEntities();
        public ActionResult Index()
        {
            List<tblFootballLeague> result = (List<tblFootballLeague>)Context.tblFootballLeagues.Where(x => x.Status == "win").ToList();
            return View(result);
        }
    }
}