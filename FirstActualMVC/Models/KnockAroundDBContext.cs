using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FirstActualMVC.Models.ENTITIES;

namespace FirstActualMVC.Models
{
    public class KnockAroundDBContext : DbContext
    {
        public KnockAroundDBContext() : base("name=KnockAroundDatabaseContext")
        {

        }
        public DbSet<tbl_customer> Customer { get; set; }
        public DbSet<tbl_orders> Orders { get; set; }
        public DbSet<tbl_salesman> Salesman { get; set; }
    }
}