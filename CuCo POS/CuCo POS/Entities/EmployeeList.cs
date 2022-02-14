using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuCo_POS.Entities
{
    public class EmployeeList
    {
        public int EmpID { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public string EmpAddress { get; set; }
        public string EmpPhone { get; set; }

        public virtual UserList User { get; set; }
    }
}
