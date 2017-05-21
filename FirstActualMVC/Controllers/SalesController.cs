using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstActualMVC.Models.ConnectToDatabase;
using FirstActualMVC.Models.ENTITIES;

namespace FirstActualMVC.Controllers
{
    public class SalesController : Controller
    {
        DbModel dbmodel = new DbModel();

        public ActionResult Salesman()
        {
            ViewBag.Message = "Sales people.";
            List<tbl_salesman> Salesman = dbmodel.GetAllSalesmen();
            return View(Salesman);
        }

        public ActionResult EditSalesPeople(int id)
        {
            tbl_salesman salesman = dbmodel.GetSalesman(id);
            return View(salesman);
        }

        public ActionResult SalesDetail(int id)
        {
            tbl_salesman saledetail = dbmodel.SalesDetails(id);
            return View(saledetail);
        }
    }
}