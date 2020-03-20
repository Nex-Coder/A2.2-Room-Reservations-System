using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1.lib
{
    public class BookingCollections
    {

        private static MySqlConnection connect = new MySqlConnection("server=nexushub.xyz;port=3306;database=roomreservations;uid=roomManager;pwd=apipassword;");
        // methods
        public static DataTable List()

        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM BOOKINGMANAGEMENT", connect);
            MySqlDataAdapter da = new MySqlDataAdapter();
            connect.Open();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            connect.Close();
            return dt = ds.Tables[0];
        }


    }

}
