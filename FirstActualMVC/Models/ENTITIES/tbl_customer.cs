//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirstActualMVC.Models.ENTITIES
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class tbl_customer
    {
        [Key]
        public decimal CUSTOMER_ID { get; set; }
        public string CUST_NAME { get; set; }
        public string CITY { get; set; }
        public decimal GRADE { get; set; }
        public decimal SALESMAN_ID { get; set; }
    }
}