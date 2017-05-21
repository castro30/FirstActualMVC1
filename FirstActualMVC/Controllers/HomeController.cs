using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstActualMVC.Models.ConnectToDatabase;
using FirstActualMVC.Models.ENTITIES;

namespace FirstActualMVC.Controllers
{
    public class HomeController : Controller
    {
        DbModel dbmodel = new DbModel();



        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Welcome to the CC's page. Welcome to my Applications";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        #region Comment1
        /*
        public ActionResult Customer()
        {
            ViewBag.Message = "Customers.";
            List<tbl_customer> customer = dbmodel.GetAllCustomers();
            return View(customer);
        }*/
        #endregion


        #region Comment5
        /*public ActionResult Orders()
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
    }*/
        #endregion

        #region Comment2
        /*public ActionResult Edit(int id)
        {
            tbl_customer customer = dbmodel.GetCustomer(id);
            return View(customer);
        }*/
        #endregion

        #region SalesComment
        /*public ActionResult Salesman()
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
        }*/

#endregion


        #region Comment3
        /*public ActionResult CustomerDetail(int id)
        {
            tbl_customer custdetail = dbmodel.CustomerDetails(id);
            return View(custdetail);
        }*/
        #endregion



        #region Comment4
        /*public ActionResult CreateCustomer()
        {
            return View(new tbl_customer
            {
                CUSTOMER_ID = 5,
                CUST_NAME = "Name",
                CITY = "City",
                GRADE = 100,
                SALESMAN_ID = 5006
            });
        }

         [HttpPost]
          [ValidateAntiForgeryToken]
        public ActionResult CreateCustomer(tbl_customer customerRow)
        {

            if (ModelState.IsValid)
            {
                dbmodel.CreateNewCustomer(customerRow);
                return RedirectToAction("customerRow");
            }

            return View(customerRow);
        }*/

        #endregion

    }
}
 