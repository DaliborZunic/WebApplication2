using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class OrgUnitsController : Controller
    {
        // GET: OrgUnits
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EditOrgUnitMembers()
        {
            return View();
    }
}
}