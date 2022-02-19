using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuCo_POS.Entities
{
    public class PaymentType
    {
        [Key]
        public int PaymentID { get; set; }
        public string Paymenttype { get; set; }
    }
}
