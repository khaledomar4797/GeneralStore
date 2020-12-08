using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }

        [Required]
        public int CustomerID { get; set; }
        [ForeignKey(nameof(CustomerID))]
        public virtual Customer Customer { get; set; }

        [Display(Name = "Date of Transaction")]
        [DataType(DataType.DateTime)]
        public DateTime? DateOfTransaction { get; set; }

        [Required]
        public int Quantity { get; set; }

    }
}