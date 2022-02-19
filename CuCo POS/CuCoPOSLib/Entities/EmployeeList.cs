using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuCo_POS.Entities
{
    public class EmployeeList
    {
        [Key]
        public int EmpID { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public string EmpAddress { get; set; }
        public string EmpPhone { get; set; }

        [ForeignKey("UserID")]
        public virtual UserList User { get; set; }
    }
}
