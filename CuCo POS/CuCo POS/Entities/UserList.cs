using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuCo_POS.Entities
{
    public class UserList
    {
        [Key]
        public int UserID { get; set; }
        public virtual EmployeeList Employee { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserPosition { get; set; }
        public string UserAccess { get; set; }
        public bool isActive { get; set; }
    }
}
