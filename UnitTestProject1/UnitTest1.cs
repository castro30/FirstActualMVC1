using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            /*
             *   return View(new tbl_customer
            {
                CUSTOMER_ID = 5,
                CUST_NAME = "Name",
                CITY = "City",
                GRADE = 100,
                SALESMAN_ID = 5006
            });*/

            //Creating dummy data
            var mockedCustomers = new List<>
            {
                new Movie()
                {
                    Genre = "Horror",
                    ID = 200,
                    Title = "Run for your life",
                    Price = new decimal(13.99),
                    Rating = "PG",
                    ReleaseDate = DateTime.Today
                },
                new Movie()
                {
                    Genre = "Sci-Fi",
                    ID = 201,
                    Title = "Time Travel",
                    Price = new decimal(17.99),
                    Rating = "PG",
                    ReleaseDate = DateTime.Today
                }
            }.AsQueryable();

        }
    }
}
