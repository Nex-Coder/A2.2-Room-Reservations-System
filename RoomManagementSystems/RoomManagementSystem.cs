using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RoomManagementSystems;

namespace RoomManagementSystem
{
    public partial class rmsForm : Form
    {
        private List<RoomObj> rooms = new List<RoomObj>();

        private void List() 
        {
            // Clears The list and then re-adds the column data (Name, Width, Alignment).
            rooms.Clear();
            roomView.Clear();
            roomView.Columns.Add("Room ID", 85, HorizontalAlignment.Left);
            roomView.Columns.Add("Name", 120, HorizontalAlignment.Left);
            roomView.Columns.Add("Description", 200, HorizontalAlignment.Left);
            roomView.Columns.Add("Opening Hour", 112, HorizontalAlignment.Left);
            roomView.Columns.Add("Closing Hour", 112, HorizontalAlignment.Left);
            roomView.Columns.Add("Avaliable", 80, HorizontalAlignment.Left);


            DataTable dt = RoomObjCollection.List();

            foreach (DataRow dr in dt.Rows)
            {
                rooms.Add(new RoomObj((int)dr["roomid"],         // ID
                dr["roomname"].ToString(),                       // Name
                dr["roomdescription"].ToString(),                // Desc
                dr["roomopeningtime"].ToString(),                // Open
                dr["roomclosingtime"].ToString(),                // Close
                Convert.ToBoolean(dr["roomstatus"])));           // Avaliable/Status
            }

            foreach (var roomobj in rooms)
            {
                ListViewItem dbRow = new ListViewItem(roomobj.GetRoomID().ToString());
                dbRow.SubItems.Add(roomobj.GetRoomName());
                dbRow.SubItems.Add(roomobj.GetRoomDesc());
                dbRow.SubItems.Add(roomobj.GetOpenHour());
                dbRow.SubItems.Add(roomobj.GetCloseHour());
                dbRow.SubItems.Add(roomobj.GetAvailable().ToString());
                roomView.Items.AddRange(new ListViewItem[] { dbRow });
            }
        }

        public rmsForm()
        {
            InitializeComponent();
            List();
        }

        // Update/Refresh Button.
        private void button1_Click(object sender, EventArgs e)
        {
            List();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            RoomObjCollection.Add(new RoomObj(0, txtBoxName.Text, rtxtBoxDesc.Text, txtBoxOpenHour.Text, txtBoxCloseHour.Text, checkBoxAvaliable.Checked));
            List();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (roomView.SelectedItems.Count == 1) 
            {
                ListViewItem item = roomView.SelectedItems[0];
                txtBoxRoomID.Text = item.SubItems[0].Text;
                txtBoxName.Text = item.SubItems[1].Text;
                rtxtBoxDesc.Text = item.SubItems[2].Text;
                txtBoxOpenHour.Text = item.SubItems[3].Text;
                txtBoxOpenMin.Text = item.SubItems[3].Text;
                txtBoxOpenSec.Text = item.SubItems[3].Text;
                txtBoxCloseHour.Text = item.SubItems[4].Text;
                txtBoxCloseMin.Text = item.SubItems[4].Text;
                txtBoxCloseSec.Text = item.SubItems[4].Text;
                checkBoxAvaliable.Checked = Convert.ToBoolean(item.SubItems[5].Text);
            }
        }
    }
}
