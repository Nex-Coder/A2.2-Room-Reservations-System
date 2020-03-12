using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.lib
{
    class BookingObjects
    {
        // Fields
        private int bookingId;
        private int roomId;
        private string bookingInfo;
        private DateTime bookingStart;
        private DateTime bookingEnd;
        private Boolean bookingStatus;


        // Constructors
        public BookingObjects(int bookingId, int roomId, string bookingInfo, DateTime bookingStart, DateTime bookingEnd, Boolean bookingStatus)
        {
            this.bookingId = bookingId;
            this.roomId = roomId;
            this.bookingInfo = bookingInfo;
            this.bookingStart = bookingStart;
            this.bookingEnd = bookingEnd;
            this.bookingStatus = bookingStatus;
        }

        // Methods
        public int GetbookingId()
        {
            return this.bookingId;
        }
        public int GetroomId()
        {
            return this.roomId;
        }
        public string GetbookingInfo()
        {
            return this.bookingInfo;
        }
        public DateTime GetbookingStart()
        {
            return this.bookingStart;
        }
        public DateTime GetbookingEnd()
        {
            return this.bookingEnd;
        }
        public Boolean GetbookingStatus()
        {
            return this.bookingStatus;
        }


        public void SetbookingId(int bookingId)
        {
            this.bookingId = bookingId;
        }
        public void SetroomId(int roomId)
        {
            this.roomId = roomId;
        }
        public void SetbookingInfo(string bookingInfo)
        {
            this.bookingInfo = bookingInfo;
        }
        public void SetbookingStart(DateTime bookingStart)
        {
            this.bookingStart = bookingStart;
        }
        public void SetbookingEnd(DateTime bookingEnd)
        {
            this.bookingEnd = bookingEnd;
        }
        public void SetbookingStatus(Boolean bookingStatus)
        {
            this.bookingStatus = bookingStatus;
        }

    }
}
