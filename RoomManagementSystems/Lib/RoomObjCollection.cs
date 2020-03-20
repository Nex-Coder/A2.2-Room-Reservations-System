using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoomManagementSystem;

namespace RoomManagementSystems
{
    class RoomObjCollection
    {
        private static MySqlConnection dbconn = new MySqlConnection("SERVER=78.47.156.120;PORT=3306;DATABASE=roomreservations;UID=roomManager;PWD=apipassword;");
        

        public static DataTable List()
        {
            // MySQL command to get all the rows inside the desired table roomManagement.
            MySqlCommand cmd = new MySqlCommand("SELECT * from roommanagement", dbconn);
            MySqlDataAdapter da = new MySqlDataAdapter(); // Used to hold our data so we can then adapt/store it to our app.
            dbconn.Open();                                // Opens DB connection
            da.SelectCommand = cmd;                       // Runs the command and the MySqlDataAdapter captures the data.
            DataSet ds = new DataSet();     // Our future tables memory basically.
            DataTable dt = new DataTable(); // The data format we will use to return the table. 
            da.Fill(ds);                                  // Filling out table from the DataSets memory.
            dbconn.Close();                               // Closing Database connection.
            return dt = ds.Tables[0];                     // Returning the table.
        }
         
        public static void Add(RoomObj room)
        {
            // MySQL command to add the RoomObj given in the param.
            MySqlCommand cmd = new MySqlCommand("INSERT INTO roommanagement values(null, '" + room.GetRoomName() + "', '" + room.GetRoomDesc() + "', STR_TO_DATE('" + room.GetOpenHour() + "', '%H:%i:%s'), STR_TO_DATE('" + room.GetCloseHour() + "', '%H:%i:%s'), " + room.GetAvailable() + ")", dbconn);
            MySqlDataAdapter da = new MySqlDataAdapter(); // Used to hold our data so we can then adapt/store it to our app.
            dbconn.Open();                                // Opens DB connection
            da.SelectCommand = cmd;                       // Runs the command and the MySqlDataAdapter captures the data.
            DataSet ds = new DataSet();     // Our future tables memory basically.
            DataTable dt = new DataTable(); // The data format we will use to return the table.
            try                             // We are only 'trying' to fill the data incase the users request had errors...
            {                               // Errors could be non-uniquie name or null value which shouldn't be or invalid data.
                da.Fill(ds);                // filling data.
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message + "\nRequest Failed.");   // If an MySqlException is caught (because invalid command) then it will alert the user of the error.
            }
            finally
            {
                dbconn.Close();                                     // Exception or not, regardless the db connection finally closes.
            }
        }//

        public static DataTable Find(String findIn, String find)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM roommanagement WHERE " + findIn + " = '" + find + "';", dbconn);
            MySqlDataAdapter da = new MySqlDataAdapter(); // Used to hold our data so we can then adapt/store it to our app.
            dbconn.Open();                                // Opens DB connection
            da.SelectCommand = cmd;                       // Runs the command and the MySqlDataAdapter captures the data.
            DataSet ds = new DataSet();     // Our future tables memory basically.
            DataTable dt = new DataTable(); // The data format we will use to return the table. 
            da.Fill(ds);                                  // Filling out table from the DataSets memory.
            dbconn.Close();                               // Closing Database connection.
            return dt = ds.Tables[0];                     // Returning the table.
        }

    }
}
