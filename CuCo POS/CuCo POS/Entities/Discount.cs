using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuCo_POS.Entities
{
    public class Discount
    {
        [Key]
        public int DiscountID { get; set; }
        public string DiscountType { get; set; }
        public int PercentDiscount { get; set; }
        public int PercentVatEx { get; set; }
        public bool isVatEx { get; set; }
    }
}
