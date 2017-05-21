using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstActualMVC.Models.ConnectToDatabase;
using FirstActualMVC.Models.ENTITIES;

namespace FirstActualMVC.Controllers
{


    public class OrderController : Controller
    {
        DbModel dbmodel = new DbModel();

        #region UselessInformation
        /*{
            // GET: Order
            public ActionResult Index()
            {
                return View();
            }
        }*/
        #endregion

        public ActionResult Orders()
        {
            ViewBag.Message = "Orders.";
            List<tbl_orders> orders = dbmodel.GetAllOrders();
            return View(orders);
        }
        public ActionResult OrderDetail(int id)
        {
            tbl_orders orderdetails = dbmodel.OrderDetails(id);
            return View(orderdetails);
        }
        public ActionResult EditOrder(int id)
        {
            tbl_orders order = dbmodel.ChangeOrder(id);
            return View(order);
        }
    }
}