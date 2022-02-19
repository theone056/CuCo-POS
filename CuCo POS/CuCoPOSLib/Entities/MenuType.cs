
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuCo_POS.Entities
{
    public class MenuType
    {
        [Key]
        public int MenuTypeID { get; set; }
        public string MenuTypeName { get; set; }
    }
}
