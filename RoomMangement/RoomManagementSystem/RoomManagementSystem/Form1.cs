using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RoomManagementSystem
{
    public partial class Form1 : Form
    {
        // Fields
        MySqlConnection dbconn = new MySqlConnection("SERVER=78.47.156.120;PORT=3306;DATABASE=roomreservations;UID=roomManager;PWD=tmpUser;");

        // Methods/Else



        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd = new MySqlCommand("SELECT * from roommanagement", dbconn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            dbconn.Open();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            dt = ds.Tables[0];

            // Clears The list and then re-adds the column data.
            roomView1.Clear();
            roomView1.Columns.Add("Room ID", 50, HorizontalAlignment.Left);
            roomView1.Columns.Add("Name", 120, HorizontalAlignment.Left);
            roomView1.Columns.Add("Description", 240, HorizontalAlignment.Left);
            roomView1.Columns.Add("Opening Hour", 80, HorizontalAlignment.Left);
            roomView1.Columns.Add("Closing Hour", 80, HorizontalAlignment.Left);
            roomView1.Columns.Add("Avaliable", 70, HorizontalAlignment.Left);

            // loops for each row in the table.
            foreach (DataRow dr in dt.Rows)
            {
                // Adding elements into the table.
                ListViewItem dbRow = new ListViewItem(dr["roomid"].ToString());
                dbRow.SubItems.Add(dr["roomname"].ToString());
                dbRow.SubItems.Add(dr["roomdescription"].ToString());
                dbRow.SubItems.Add(dr["roomopeningtime"].ToString());
                dbRow.SubItems.Add(dr["roomclosingtime"].ToString());
                dbRow.SubItems.Add(dr["roomstatus"].ToString());
                roomView1.Items.AddRange(new ListViewItem[] { dbRow });
            }
            dbconn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
