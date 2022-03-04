using CuCoPOSLib.FACADE.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CuCoPOSLib.DAL;
using CuCoPOSLib.DAL.Interface;
using MySql.Data.MySqlClient;

namespace CuCoPOSLib.FACADE
{
    public class CuCoPOSFacade : ICuCoPOSFacade
    {
        protected string connectionString = "server=localhost;port=3306;database=CuCoPOS;uid=root;password=CuCoPOS123";

        public async Task<bool> AddItem()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            throw new NotImplementedException();
        }

        public async Task<List<Dictionary<string, object>>> GetAllMenuItem()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            ICuCoDAL cuCoDAL = new CuCoDAL();
            var _retval = await cuCoDAL.GetAllMenuItem(mySqlConnection);
            return _retval;
        }
    }
}
