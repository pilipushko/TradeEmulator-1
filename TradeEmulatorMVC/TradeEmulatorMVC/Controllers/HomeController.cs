using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuickType;

namespace TradeEmulatorMVC.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult returnChartData()
        {
            return View();
        }

        public ActionResult returnTradeHistory()
        {
            return View();
        }
    }
}