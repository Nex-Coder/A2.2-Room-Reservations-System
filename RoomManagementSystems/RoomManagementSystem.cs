using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RoomManagementSystems;

namespace RoomManagementSystem
{
    public partial class rmsForm : Form
    {
        private List<RoomObj> rooms = new List<RoomObj>();

        private void List(DataTable dt)
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


            // DataTable dt = RoomObjCollection.List();

            foreach (DataRow dr in dt.Rows)
            {
                rooms.Add(new RoomObj((int)dr["roomid"],             // ID
                dr["roomname"].ToString(),                           // Name
                dr["roomdescription"].ToString(),                    // Desc
                TimeSpan.Parse(dr["roomopeningtime"].ToString()),    // Open
                TimeSpan.Parse(dr["roomclosingtime"].ToString()),    // Close
                Convert.ToBoolean(dr["roomstatus"])));               // Avaliable/Status
            }

            // Filling table.
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

        // Upon Initalisation, load the form and list everything in the database using this list class (to list given data) 
        // and RoomObjCollection.List(); to give a list of all from the roommangement table.
        public rmsForm()
        {
            InitializeComponent();
            List(RoomObjCollection.List());
        }

        // Update/Refresh Button.
        private void button1_Click(object sender, EventArgs e)
        {
            List(RoomObjCollection.List());
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            RoomObjCollection.Add(new RoomObj(0, txtBoxName.Text, rtxtBoxDesc.Text, TimeSpan.Parse(txtBoxOpenHour.Text), TimeSpan.Parse(txtBoxCloseHour.Text), checkBoxAvaliable.Checked));
            List(RoomObjCollection.List());
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            String findIn = "";

            if (checkedListBox1.CheckedItems.Count == 1)
            {
                // there is only one possible check thanks to the if statement so it's not so taxing.
                foreach (int indexChecked in checkedListBox1.CheckedIndices)
                {
                    switch (indexChecked)
                    {
                        case 0:
                            findIn = "roomID";
                            break;
                        case 1:
                            findIn = "roomName";
                            break;
                        case 2:
                            findIn = "roomDescription";
                            break;
                        case 3:
                            findIn = "roomOpeningTime";
                            break;
                        case 4:
                            findIn = "roomClosingTime";
                            break;
                        case 5:
                            findIn = "roomStatus";
                            break;
                    }
                }

                if (txtBoxFind.Text.ToLower() == "true")
                {
                    List(RoomObjCollection.Find(findIn, "1"));
                }
                else
                {
                    List(RoomObjCollection.Find(findIn, txtBoxFind.Text));
                }
            }
            else
            {
                MessageBox.Show("The number of options (" + checkedListBox1.CheckedItems.Count + ") checked is not valid.\nPlease only select 1.");
            }
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
                txtBoxCloseHour.Text = item.SubItems[4].Text;
                checkBoxAvaliable.Checked = Convert.ToBoolean(item.SubItems[5].Text);
            }
        }

        private void lblIn_Click(object sender, EventArgs e)
        {

        }
    }
}
