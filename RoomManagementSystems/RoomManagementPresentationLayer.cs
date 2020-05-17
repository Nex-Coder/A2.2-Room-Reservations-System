using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RoomManagementSystems;
using System.Linq;

namespace RoomManagementSystem
{
    public partial class rmsForm : Form
    {   // Fields
        private List<RoomObj> Rooms = new List<RoomObj>();

        // Methods
        private void List(DataTable dt)
        {
            // Clears The list and then re-adds the column data (Name, Width, Alignment). Needs clearing because we need to remove the rows associated.
            Rooms.Clear();
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
                Rooms.Add(new RoomObj((int)dr["roomid"],             // ID
                dr["roomname"].ToString(),                           // Name
                dr["roomdescription"].ToString(),                    // Desc
                TimeSpan.Parse(dr["roomopeningtime"].ToString()),    // Open
                TimeSpan.Parse(dr["roomclosingtime"].ToString()),    // Close
                Convert.ToBoolean(dr["roomstatus"])));               // Avaliable/Status
            }

            // Filling table.
            foreach (var roomobj in Rooms)
            {
                ListViewItem dbRow = new ListViewItem(roomobj.GetRoomID().ToString());
                dbRow.SubItems.Add(roomobj.GetRoomName());              // ID
                dbRow.SubItems.Add(roomobj.GetRoomDesc());              // Name
                dbRow.SubItems.Add(roomobj.GetOpenHour());              // Desc
                dbRow.SubItems.Add(roomobj.GetCloseHour());             // Open
                dbRow.SubItems.Add(roomobj.GetAvailable().ToString());  // Close
                roomView.Items.AddRange(new ListViewItem[] { dbRow });  // Avaliable/Status
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
            List(RoomObjCollection.List()); // Lists the newest data.
        }

        // New Room/Row button
        private void buttonNew_Click(object sender, EventArgs e)
        {
            //Creates a new room obj and gives it to the Add method. Aftwards List is called to automatically refresh the data.

            try
            {
                RoomObj UsersRoom = new RoomObj(0, txtBoxName.Text, rtxtBoxDesc.Text, TimeSpan.Parse(txtBoxOpenHour.Text), TimeSpan.Parse(txtBoxCloseHour.Text), checkBoxAvaliable.Checked);
                if (UsersRoom.Validate() == "") // Checking for anything not caught by the handle exception.
                {
                    RoomObjCollection.Add(UsersRoom);
                    List(RoomObjCollection.List());
                }
                else
                {
                    MessageBox.Show("Error: Your Room contains invalid values\n" + UsersRoom.Validate());
                }

            }
            catch (Exception)
            {
                MessageBox.Show("One or more of your values is incorrect. Please check for mistakes.\nRequest Failed.");
            }

        }

        // Find Button.
        private void buttonFind_Click(object sender, EventArgs e)
        {
            String findIn = ""; // Needs to be declared otherwise compiler screams at you.

            RadioButton radio = radioGroup.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault(); // Gets the radio button in the group thats checked using a simple function and predicate.
            if (radio != null)
            {
                switch (radio.Name)
                {
                    case "rbRoomID":
                        findIn = "roomID";
                        break;
                    case "rbName":
                        findIn = "roomName";
                        break;
                    case "rbDescription":
                        findIn = "roomDescription";
                        break;
                    case "rbOpenningHour":
                        findIn = "roomOpeningTime";
                        break;
                    case "rbClosingHour":
                        findIn = "roomClosingTime";
                        break;
                    case "rbAvaliable":
                        findIn = "roomStatus";
                        break;
                }

                switch (txtBoxFind.Text.ToLower())
                {
                    case "true":
                        List(RoomObjCollection.Find(findIn, "1"));
                        break;
                    case "false":
                        List(RoomObjCollection.Find(findIn, "0"));
                        break;
                    default:
                        List(RoomObjCollection.Find(findIn, txtBoxFind.Text));
                        break;
                }

            }
            else
            {
                MessageBox.Show("Please select an option to find in / filter through.");
            }
        }

        // Select button which gets the selected element from roomView and sets the values of each column to the corisponding row.
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (txtBoxRoomID.TextLength <= 0)
            {
                MessageBox.Show("Please select a room to edit first, then try deleting again.");
            }
            else
            {
                RoomObj UsersRoom = new RoomObj(int.Parse(txtBoxRoomID.Text), txtBoxName.Text, rtxtBoxDesc.Text, TimeSpan.Parse(txtBoxOpenHour.Text), TimeSpan.Parse(txtBoxCloseHour.Text), checkBoxAvaliable.Checked);
                if (UsersRoom.Validate() == "") // Checking for anything not caught by the handle exception.
                {
                    RoomObjCollection.Delete(UsersRoom);
                    List(RoomObjCollection.List()); //Refresh
                }
                else
                {
                    MessageBox.Show("Error: Your Room contains invalid values\n" + UsersRoom.Validate());
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtBoxRoomID.Text = "";
            txtBoxName.Text = "";
            rtxtBoxDesc.Text = "";
            txtBoxOpenHour.Text = "";
            txtBoxCloseHour.Text = "";
            checkBoxAvaliable.Checked = false;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (txtBoxRoomID.TextLength <= 0 || txtBoxName.TextLength <= 0)
            {
                MessageBox.Show("Please select a room to edit first or make sure a name is provided.\nRequest Failed.");
            }
            else
            {
                try
                {
                    RoomObj UsersRoom = new RoomObj(int.Parse(txtBoxRoomID.Text), txtBoxName.Text, rtxtBoxDesc.Text, TimeSpan.Parse(txtBoxOpenHour.Text), TimeSpan.Parse(txtBoxCloseHour.Text), checkBoxAvaliable.Checked);
                    if (UsersRoom.Validate() == "") // Checking for anything not caught by the handle exception.
                    {
                        RoomObjCollection.Edit(UsersRoom);
                        List(RoomObjCollection.List()); //Refresh
                    }
                    else
                    {
                        MessageBox.Show("Error: Your Room contains invalid values\n" + UsersRoom.Validate());
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("One or more of your values is incorrect. Please check for mistakes.\nRequest Failed.");
                }
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            String filterIn = "";

            RadioButton radio = radioGroup.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault(); // Gets the radio button in the group thats checked using a simple function and predicate.
            if (radio != null)
            {
                switch (radio.Name) // Converts the radio button to the column name in database.
                {
                    case "rbRoomID":
                        filterIn = "roomID";
                        break;
                    case "rbName":
                        filterIn = "roomName";
                        break;
                    case "rbDescription":
                        filterIn = "roomDescription";
                        break;
                    case "rbOpenningHour":
                        filterIn = "roomOpeningTime";
                        break;
                    case "rbClosingHour":
                        filterIn = "roomClosingTime";
                        break;
                    case "rbAvaliable":
                        filterIn = "roomStatus";
                        break;
                }

                switch (txtBoxFind.Text.ToLower()) // Converts true and false to 1 or 0 respectively else submits a normal request.
                {
                    case "true":
                        List(RoomObjCollection.Filter(filterIn, "1"));
                        break;
                    case "false":
                        List(RoomObjCollection.Filter(filterIn, "0"));
                        break;
                    default:
                        List(RoomObjCollection.Filter(filterIn, txtBoxFind.Text));
                        break;
                }

            }
            else
            {
                MessageBox.Show("Please select an option to find in / filter through.");
            }
        }
    }
}
