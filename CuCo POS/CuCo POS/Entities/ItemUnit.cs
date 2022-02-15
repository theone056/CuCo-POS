using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuCo_POS.Entities
{
    public class ItemUnit
    {
        [Key]
        public int UnitID { get; set; }
        public string Unit { get; set; }
    }
}
