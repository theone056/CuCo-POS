using CuCoPOSLib.DAL.Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuCoPOSLib.DAL
{
    public class CuCoDAL : ICuCoDAL
    {
        public async Task<bool> AddItem()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Dictionary<string, object>>> GetAllMenuItem(MySqlConnection mySqlConnection)
        {
            List<Dictionary<string, object>> _result = new List<Dictionary<string, object>>();
            mySqlConnection.Open();
            string sqlCommand = "Select * from MenuList;";
            using(MySqlCommand cmd = new MySqlCommand(sqlCommand, mySqlConnection))
            {
                MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync();
                while (reader.Read())
                {
                    _result.Add(Enumerable.Range(0, reader.FieldCount).ToDictionary(reader.GetName, reader.GetValue));
                }
            }
            mySqlConnection.Close();
            mySqlConnection.Dispose();
            return _result;
        }
    }
}
