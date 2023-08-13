using MuMerch.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MuMerch.Controllers
{
    [GigManagerAccess]
    public class BandManagerController : Controller
    {
        // GET: BandManager
        public ActionResult Index()
        {
            return View();
        }

    }
}