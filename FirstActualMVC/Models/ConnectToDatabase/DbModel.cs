using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstActualMVC.Controllers;
using FirstActualMVC.Models.ENTITIES;

namespace FirstActualMVC.Models.ConnectToDatabase
{
    public class DbModel : IDbmodel
    {
        #region Customers
        public List<tbl_customer> GetAllCustomers()
        {
            using (var db = new KnockAroundDBContext())
            {
                var x = db.Customer.ToList();


                return x;
            }
        }

        public tbl_customer GetCustomer(int id)
        {
            using (var db = new KnockAroundDBContext())
            {
                return db.Customer.FirstOrDefault(x => x.CUSTOMER_ID == id);
            }
        }

        public tbl_customer CustomerDetails(int id)
        {
            using (var db = new KnockAroundDBContext())
            {
                return db.Customer.FirstOrDefault(x => x.CUSTOMER_ID == id);
            }
        }
        #endregion

        #region Orders
        public List<tbl_orders> GetAllOrders()
        {
            using (var db = new KnockAroundDBContext())
            {
                return db.Orders.ToList();
            }
        }

        public tbl_orders ChangeOrder(int id)
        {
            using (var db = new KnockAroundDBContext())
            {
                return db.Orders.FirstOrDefault(x => x.ORD_NO == id);
            }
        }
        public tbl_orders OrderDetails(int id)
        {
            using (var db = new KnockAroundDBContext())
            {
                return db.Orders.FirstOrDefault(x => x.ORD_NO == id);
            }
        }
        #endregion

        #region Salesmen
        public List<tbl_salesman> GetAllSalesmen()
        {
            using (var db = new KnockAroundDBContext())
            {
                return db.Salesman.ToList();
            }
        }

        public tbl_salesman GetSalesman(int id)
        {
            using (var db = new KnockAroundDBContext())
            {
                return db.Salesman.FirstOrDefault(x => x.SALESMAN_ID == id);
            }
        }

        public tbl_salesman SalesDetails(int id)
        {
            using (var db = new KnockAroundDBContext())
            {
                return db.Salesman.FirstOrDefault(x => x.SALESMAN_ID == id);
            }
        }
        #endregion


        public tbl_customer CreateNewCustomer(tbl_customer cust)
        {
            using (var db = new KnockAroundDBContext())
            {
                var newcust = db.Customer.Add(cust);
                db.SaveChanges();
                return newcust;
            }

        }

        public void EditTheCustomer(tbl_customer cust)
        {
            using (var db = new KnockAroundDBContext())
            {
                //var editcust = db.Customer.Add(cust);
                db.Entry(cust).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                
            }
        }

    }
}