﻿using MySql.Data.MySqlClient;
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
        protected static String sError = "";

        public static DataTable List()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * from roommanagement", dbconn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            dbconn.Open();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet(); // Our future tables memory basically.
            DataTable dt = new DataTable();
            da.Fill(ds);
            dbconn.Close();
            return dt = ds.Tables[0];
        }

        public static void Add(RoomObj room)
        {
            // INSERT INTO `roommanagement`(`roomID`, `roomName`, `roomDescription`, `roomOpeningTime`, `roomClosingTime`, `roomStatus`) VALUES (null, "test name", "test description", 1200, 1400, 0);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO roommanagement values(null, '" + room.GetRoomName() + "', '" + room.GetRoomDesc() + "', STR_TO_DATE('" + room.GetOpenHour() + "', '%H:%i:%s'), STR_TO_DATE('" + room.GetCloseHour() + "', '%H:%i:%s'), " + room.GetAvailable() + ")", dbconn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            dbconn.Open();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet(); // Our future tables memory basically.
            DataTable dt = new DataTable();
            try
            {
                da.Fill(ds);
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message + "\nRequest Failed.");
            }
            finally
            {
                dbconn.Close();
            }
        }

        public static DataTable Find(String findIn, String find)
        {

            /*string sql = "SELECT* FROM roommanagement WHERE @val1 = @val2;";
            MySqlCommand cmd = new MySqlCommand(sql, dbconn);
            cmd.Parameters.AddWithValue("@val1", findIn);
            cmd.Parameters.AddWithValue("@val2", find);
            dbconn.Open();
            cmd.Prepare();*/
            MessageBox.Show("SELECT * FROM roommanagement WHERE " + findIn + " = '" + find + "';");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM roommanagement WHERE "+findIn+ " = '" + find + "';", dbconn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            dbconn.Open();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet(); // Our future tables memory basically.
            DataTable dt = new DataTable();
            da.Fill(ds);
            dbconn.Close();
            return dt = ds.Tables[0];
        }

            public static void CloseDB()
            {
                dbconn.Close();
            }
        }
    }