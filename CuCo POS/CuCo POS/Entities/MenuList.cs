using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuCo_POS.Entities
{
    public class MenuList
    {
        public int MenuID { get; set; }

        public string MenuName { get; set; }

        public double MenuPrice { get; set; }

        public string Menu_Type { get; set; }

        public bool isAvail { get; set; }

        public string ImageLocation { get; set; }

    }
}
