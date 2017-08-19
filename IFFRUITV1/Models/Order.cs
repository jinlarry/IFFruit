using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using IFFRUITV1.Models;

namespace IFFRUITV1.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public int ContactNumber { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Order Quantity")]
        public int OrderQuantity { get; set; }

        [Required]
        [Display(Name ="Price(Per kg)")]
        public decimal OrderPrice { get; set; }

        public string OrderTitle { get; set; } // auto generated.

        [Display(Name = "Order Description")]
        public string OrderDescription { get; set; }

        public DateTime OrderPlacedDate { get; set; } // auto generated.

        [Required]
        [Display(Name = "Product Arrive Date")]
        public DateTime ArrivalDate { get; set; }

        public bool IsVerified { get; set; } // for backend.

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
