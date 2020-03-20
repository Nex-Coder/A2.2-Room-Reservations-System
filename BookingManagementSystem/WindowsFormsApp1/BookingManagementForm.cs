using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using WindowsFormsApp1.lib;

namespace WindowsFormsApp1
{
    public partial class BookingManagementForm : Form
    {
        List<BookingObjects> bookings = new List<BookingObjects>();
        public BookingManagementForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            bookings.Clear();
            listView1.Columns.Add("Booking ID", 65, HorizontalAlignment.Left);
            listView1.Columns.Add("Room ID", 60, HorizontalAlignment.Left);
            listView1.Columns.Add("Booking Info", 75, HorizontalAlignment.Left);
            listView1.Columns.Add("Booking Start", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Booking End", 75, HorizontalAlignment.Left);
            listView1.Columns.Add("Booking Status", 80, HorizontalAlignment.Left);
            DataTable dt = BookingCollections.List();
            foreach (DataRow dr in dt.Rows)
            {
                // MessageBox.Show((string)dr["BookingInfo"]);
                bookings.Add(new BookingObjects((int)dr["bookingID"],
                    (int)dr["roomID"],
                    dr["bookingInfo"].ToString(),
                    DateTime.Parse(dr["bookingStart"].ToString()),
                    DateTime.Parse(dr["bookingEnd"].ToString()),
                    Convert.ToBoolean(dr["bookingStatus"])));
            }
            foreach (var BookingObjects in bookings)
            {
                ListViewItem row = new ListViewItem(BookingObjects.GetbookingId().ToString());
                row.SubItems.Add(BookingObjects.GetroomId().ToString());
                row.SubItems.Add(BookingObjects.GetbookingInfo());
                row.SubItems.Add(BookingObjects.GetbookingStart().ToString());
                row.SubItems.Add(BookingObjects.GetbookingEnd().ToString());
                row.SubItems.Add(BookingObjects.GetbookingStatus().ToString());
                listView1.Items.AddRange(new ListViewItem[] { row });
            }
        }

        private void BookingManagementForm_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
