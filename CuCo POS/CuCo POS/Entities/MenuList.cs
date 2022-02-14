using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuCo_POS.Entities
{
    public class MenuList
    {
        public int MenuID { get; set; }

        public string MenuName { get; set; }

        public int MenuPrice { get; set; }

        public string MenuType { get; set; }

        public bool isAvail { get; set; }

    }
}
