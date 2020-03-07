using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomManagementSystems
{
    class RoomObj

    {
        // Fields
        private int roomID;
        private String roomName;
        private String roomDesc;
        private String openningHour;
        private String closingHour;
        private Boolean available;

        // Constructors
        public RoomObj(int roomID, String roomName, String roomDesc, String openningHour, String closingHour, Boolean avaliable)
        {
            this.roomID = roomID;
            this.roomName = roomName;
            this.roomDesc = roomDesc;
            this.openningHour = openningHour;
            this.closingHour = closingHour;
            this.available = avaliable;
        }

        // Methods

        //Set
        public void SetRoomName(String roomName) 
        {
            if (roomName.Length <= 24)
            {
                this.roomName=roomName;
            }
            else
            {
                throw new ArgumentException(String.Format("{0} is not a valid", roomName),
                      "room name length");
            }

        }

        public void SetRoomDesc(String roomDesc) 
        {
            if (roomDesc.Length <= 120)
            {
                this.roomDesc = roomDesc;
            } else
            {
                throw new ArgumentException(String.Format("{0} is not a valid", roomDesc),
                      "description length");
            }
        }

        public void SetOpenningHour(String openningHour) 
        {
            this.openningHour = openningHour;
        }

        public void SetClosingHour(String closingHour) 
        {
            this.closingHour=closingHour;
        }

        public void SetAvailable(Boolean available) 
        {
            this.available = available;
        }

        // Get
        public int GetRoomID() 
        {
            return roomID;
        }

        public string GetRoomName() 
        {
            return roomName;
        }

        public string GetRoomDesc()
        {
            return roomDesc;
        }

        public string GetOpenHour()
        {
            return openningHour;
        }

        public string GetCloseHour()
        {
            return closingHour;
        }

        public Boolean GetAvailable()
        {
            return available;
        }
    }
}
