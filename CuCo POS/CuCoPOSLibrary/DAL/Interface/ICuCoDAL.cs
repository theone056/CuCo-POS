using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuCoPOSLib.DAL.Interface
{
    public interface ICuCoDAL
    {
        Task<List<Dictionary<string, object>>> GetAllMenuItem(MySqlConnection mySqlConnection);

        Task<bool> AddItem();
    }
}
