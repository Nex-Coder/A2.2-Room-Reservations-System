using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomManagementSystems
{
    public class RoomObj

    {
        // Fields
        private int RoomID;
        private String RoomName;
        private String RoomDesc;
        private TimeSpan OpenningHour = new TimeSpan(0, 0, 0);
        private TimeSpan ClosingHour = new TimeSpan(0, 0, 0);
        private Boolean Available;

        // Constructors
        public RoomObj(int roomID, String roomName, String roomDesc, TimeSpan openningHour, TimeSpan closingHour, Boolean avaliable)
        {
            this.RoomID = roomID;
            this.RoomName = roomName;
            this.RoomDesc = roomDesc;
            this.OpenningHour = openningHour;
            this.ClosingHour = closingHour;
            this.Available = avaliable;
        }

        // Methods
        //Set

        // No Room ID setter because the database generates that for us.

        public void SetRoomName(String roomName)
        {
            this.RoomName = roomName;
        }

        public void SetRoomDesc(String roomDesc)
        {
            this.RoomDesc = roomDesc;

        }

        public void SetOpenningHour(TimeSpan openningHour)
        {
            this.OpenningHour = openningHour;
        }

        public void SetClosingHour(TimeSpan closingHour)
        {
            this.ClosingHour = closingHour;
        }

        public void SetAvailable(Boolean available)
        {
            this.Available = available;
        }

        // Get
        public int GetRoomID()
        {
            return RoomID; // Only usefull for editing a real room in the database already. Otherwise its represented symantically.
        }

        public string GetRoomName()
        {
            return RoomName;
        }

        public string GetRoomDesc()
        {
            return RoomDesc;
        }

        public string GetOpenHour()
        {
            return OpenningHour.ToString();
        }

        public string GetCloseHour()
        {
            return ClosingHour.ToString();
        }

        public Boolean GetAvailable()
        {
            return Available;
        }

        public String Validate()
        {
            String Error = "";
            // Room ID validation
            if (this.RoomID > 255)
            {
                Error += "RoomID cannot be bigger than 255.";
            }
            else if (this.RoomID < 0)
            {
                Error += "RoomID cannot be a negative value.";
            }

            //Room Name validation
            if (this.RoomName.Count() > 24)
            {
                Error += "Room Name: Cannot be bigger than allowed size (24 characters).";
            }
            else if (this.RoomName.Count() == 0)
            {
                Error += "Room Name: Cannot be an empty name.";
            }

            //Room Description validation
            if (this.RoomDesc.Count() > 120)
            {
                Error += "Room Description: Cannot be bigger than allowed size (120 characters).";
            }
            // Can be empty. Is not required field.

            // Openning Hour validation
            if (this.OpenningHour >= new TimeSpan(23, 59, 59))
            {
                Error += "Openning Hour: Cannot be greater than 23:59:59. Midnight must be represented by 00:00:00.";
            }
            else if (this.OpenningHour < new TimeSpan(00, 00, 00))
            {
                Error += "Openning Hour: Cannot be a negative time i.e. less than 00:00:00.";
            }

            // Closing Hour validation
            if (this.ClosingHour >= new TimeSpan(23, 59, 59))
            {
                Error += "Openning Hour: Cannot be greater than 23:59:59. Midnight must be represented by 00:00:00.";
            }
            else if (this.ClosingHour < new TimeSpan(00, 00, 00))
            {
                Error += "Openning Hour: Cannot be a negative time i.e. less than 00:00:00.";
            }

            // Avaliability cannot be an invalid value, it is either true or false.

            return Error;
        }

    }
}
