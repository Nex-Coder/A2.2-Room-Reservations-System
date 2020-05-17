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
    /// <summary>
    /// This Collection is a library with static methods to link the RoomObj object with the Data Layer. 
    ///  Also, this class is specifically designed for a MySQL server. The server must be able to respond to MySQL queries.
    ///  <para />
    /// Connection details can be changed at any time by editing the static field dbconn. 
    /// To 'currently' view the Data layer and details, please go to https://nexhub.co.uk/phpmyadmin or http://78.47.156.120/78.47.156.120 and use the same connection details as dbconn (Username: roomManager, Password: apipassword). Obviously this won't work if using another server.
    /// <para />
    /// Note: Upon actual implementation the dbconn fields should be made close source or should be provided by the Presentation Layer (GUI) to the ChangeDbConnection method. These details are currently easy to access and give access to sensetive infomation once senseitive information is being stored.
    /// </summary>
    public class RoomObjCollection
    {
        private static MySqlConnection dbconn = new MySqlConnection("SERVER=78.47.156.120;PORT=3306;DATABASE=roomreservations;UID=roomManager;PWD=apipassword;");

        /// <summary>
        /// Gets the most recent data from the Room Management Table via a MySQL command.
        /// </summary>
        /// <returns>A DataTable filled with the data from the Room Management table.</returns>
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

        /// <summary>
        /// Inserts the given room object into the database Room Management table via a MySQL Command.
        /// </summary>
        /// <param name="room">A RoomObj that contains valid fields to be inserted into the table.</param>
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

        /// <summary>
        /// Accepts two paramaters which are used to find (one of) what you want in the desired column. This is done via a MySQL command to search within the Room Management Table.
        /// </summary>
        /// <param name="findIn">The column to search through.</param>
        /// <param name="find">The desired field to be search for.</param>
        /// <returns>The results of what was found.</returns>
        public static DataTable Find(String findIn, String find)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM roommanagement WHERE " + findIn + " = '" + find + "' LIMIT 1;", dbconn);
            MySqlDataAdapter da = new MySqlDataAdapter(); // Used to hold our data so we can then adapt/store it to our app.
            dbconn.Open();                                // Opens DB connection
            da.SelectCommand = cmd;                       // Runs the command and the MySqlDataAdapter captures the data.
            DataSet ds = new DataSet();     // Our future tables memory basically.
            DataTable dt = new DataTable(); // The data format we will use to return the table. 
            da.Fill(ds);                                  // Filling out table from the DataSets memory.
            dbconn.Close();                               // Closing Database connection.
            return dt = ds.Tables[0];                     // Returning the table.
        }

        /// <summary>
        /// Accepts two paramaters which are used to find what is requested and in which desired column and returns all matching fields. This is done via a MySQL command to search within the Room Management Table.
        /// </summary>
        /// <param name="filterIn">The column to search through.</param>
        /// <param name="filter">The desired field to be search for.</param>
        /// <returns></returns>
        public static DataTable Filter(String filterIn, String filter)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM roommanagement WHERE " + filterIn + " LIKE '%" + filter + "%';", dbconn);
            MySqlDataAdapter da = new MySqlDataAdapter(); // Used to hold our data so we can then adapt/store it to our app.
            dbconn.Open();                                // Opens DB connection
            da.SelectCommand = cmd;                       // Runs the command and the MySqlDataAdapter captures the data.
            DataSet ds = new DataSet();     // Our future tables memory basically.
            DataTable dt = new DataTable(); // The data format we will use to return the table. 
            da.Fill(ds);                                  // Filling out table from the DataSets memory.
            dbconn.Close();                               // Closing Database connection.
            return dt = ds.Tables[0];                     // Returning the table.
        }

        /// <summary>
        /// Deletes a room given from the database Room Management table.
        /// </summary>
        /// <param name="room">The RoomObj you wish to delete in the database.</param>
        public static void Delete(RoomObj room)
        {
            // MySQL command to add the RoomObj given in the param.
            MySqlCommand cmd = new MySqlCommand("DELETE FROM roomManagement WHERE roomID='" + room.GetRoomID() + "';", dbconn);
            dbconn.Open();                                // Opens DB connection
            try                            // We are only 'trying' to run the command, if there any errors then we will catch them during these statements similar to Add().
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message + "\nRequest Failed.");   // If an MySqlException is caught (because invalid command) then it will alert the user of the error.
            }
            finally
            {
                dbconn.Close();                                     // Exception or not, regardless the db connection finally closes.
            }
        }
        /// <summary>
        /// Can be used to edit or update a given room via a passed RoomObj. It should be noted that the RoomID is assigned by the server and isn't editable.
        /// </summary>
        /// <param name="room">The room to edit/update. (With an accurate ID to find and other fields to edit or keep the same.)</param>
        public static void Edit(RoomObj room)   // Equivalent to update. 
        {
            // MySQL command to add the RoomObj given in the param.
            MySqlCommand cmd = new MySqlCommand("UPDATE roommanagement SET roomName = '" + room.GetRoomName() + "', roomDescription = '" + room.GetRoomDesc() + "', roomOpeningTime = STR_TO_DATE('" + room.GetOpenHour() + "', '%H:%i:%s'), roomClosingTime = STR_TO_DATE('" + room.GetCloseHour() + "', '%H:%i:%s'), roomStatus = '" + Convert.ToInt32(room.GetAvailable()) + "' WHERE roomID = " + room.GetRoomID(), dbconn);
            dbconn.Open();
            try                            // We are only 'trying' to run the command, if there any errors then we will catch them during these statements similar to Add().
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message + "\nRequest Failed.");   // If an MySqlException is caught (because invalid command) then it will alert the user of the error.
            }
            finally
            {
                dbconn.Close();                                     // Exception or not, regardless the db connection finally closes.
            }
        }

        /// <summary>
        /// Changes the default infomation (unless removed in a future update) of dbconn which holds the database access details of the Data layer.
        /// </summary>
        /// <param name="Server">The IP or domain of the MySQL server.</param>
        /// <param name="Port">The port for the MySQL server. The default should be 3306.</param>
        /// <param name="Database">Name of the database inside the server.</param>
        /// <param name="UserID">Login credentials for the user (name)./param>
        /// <param name="Password">The password/passcode for the user (name).</param>
        public static void ChangeDBConnection(String Server, String Port, String Database, String UserID, String Password)
        {
            dbconn = new MySqlConnection("SERVER="+Server+";PORT="+Port+";DATABASE="+Database+";UID="+UserID+";PWD="+Password+";");
        }
    }
}
