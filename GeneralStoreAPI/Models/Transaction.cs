using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStoreAPI.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Product))]//When inputting a foreign key, you must give it a string name of the key. nameof will do that
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        //virtual acts a foreign key placeholder until it has a value that can be populated

        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public DateTime DateOfTransaction { get; set; }
        public decimal TotalCost => Product.Price * ProductCount; //Expression body for the product price, multiplied by the count of products
        public int ProductCount { get; set; }
    }
}