using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using IFFRUITV1.Models;

namespace IFFRUITV1.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Display(Name = "Fruit Name")]
        public string ProductName { get; set; }

        [Display(Name = "Fruit Grade")]
        public int FruitGrade { get; set; }

        [Display(Name = "Guarantee Period")]
        public int GuaranteePeriod { get; set; }

        [Display(Name = "Farm Location")]
        public string FarmLocation { get; set; }

        public decimal Price { get; set; }

        public List<Order> Orders { get; set; }
    }
}
