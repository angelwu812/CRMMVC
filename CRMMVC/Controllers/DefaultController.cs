using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRMMVC.Models;
namespace CRMMVC.Controllers
{
    public class DefaultController : Controller
    {
        客戶資料Entities db = new 客戶資料Entities();
        // GET: Default
        public ActionResult Index()
        {
            return View(db.vw客入資料.ToList());
        }
 
    }
}