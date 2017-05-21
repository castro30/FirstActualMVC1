using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using FirstActualMVC.Models.ENTITIES;

namespace FirstActualMVC.Controllers
{
    interface IDbmodel
    {
        #region Customers
        List<tbl_customer> GetAllCustomers();

        tbl_customer GetCustomer(int id);

        tbl_customer CustomerDetails(int id);

        #endregion

        #region Orders
        List<tbl_orders> GetAllOrders();

        tbl_orders ChangeOrder(int id);

        tbl_orders OrderDetails(int id);
        #endregion

        #region Sales

        List<tbl_salesman> GetAllSalesmen();

        tbl_salesman GetSalesman(int id);

        tbl_salesman SalesDetails(int id);

        #endregion

        tbl_customer CreateNewCustomer(tbl_customer cust);
    }
}
