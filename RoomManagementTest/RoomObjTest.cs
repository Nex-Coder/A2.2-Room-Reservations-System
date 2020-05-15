using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoomManagementSystems;

namespace RoomManagementTest
{
    [TestClass]
    public class RoomObjTest
    {

        [TestMethod]
        public void RoomObjOk()
        {
            RoomObj TestRoom = new RoomObj(100, "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.IsNotNull(TestRoom);
        }

        [TestMethod]
        public void RoomIDExtremeMin()
        {
            RoomObj TestRoom = new RoomObj(-2147483648, "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomID(), -2147483648);
        }

        [TestMethod]
        public void RoomIDMinMinusOne()
        {
            RoomObj TestRoom = new RoomObj((0 - 1), "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomID(), -1);
        }

        [TestMethod]
        public void RoomIDMin()
        {
            RoomObj TestRoom = new RoomObj(0, "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomID(), 0);
        }

        [TestMethod]
        public void RoomIDMinPlusOne()
        {
            RoomObj TestRoom = new RoomObj((0 + 1), "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomID(), 1);
        }

        [TestMethod]
        public void RoomIDMaxMinusOne()
        {
            RoomObj TestRoom = new RoomObj((255 - 1), "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomID(), 254);
        }

        [TestMethod]
        public void RoomIDMax()
        {
            RoomObj TestRoom = new RoomObj((255), "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomID(), 255);
        }

        [TestMethod]
        public void RoomIDMaxPlusOne()
        {
            RoomObj TestRoom = new RoomObj((255 + 1), "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomID(), 256);
        }

        [TestMethod]
        public void RoomIDExtremeMax()
        {
            RoomObj TestRoom = new RoomObj((2147483647), "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomID(), 2147483647);
        }

        [TestMethod]
        public void RoomNameExtremeMin()
        {
            RoomObj TestRoom = new RoomObj(0, "", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);
            Assert.AreEqual(TestRoom.GetRoomName(), "");
        }

        [TestMethod]
        public void RoomNameMinMinusOne()
        {
            RoomObj TestRoom = new RoomObj((0 - 1), "", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);
            Assert.AreEqual(TestRoom.GetRoomName(), "");
        }

        [TestMethod]
        public void RoomNameMin()
        {
            RoomObj TestRoom = new RoomObj(0, "R", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);
            Assert.AreEqual(TestRoom.GetRoomName(), "R");
        }

        [TestMethod]
        public void RoomNameMinPlusOne()
        {
            RoomObj TestRoom = new RoomObj((0 + 1), "Ro", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);
            Assert.AreEqual(TestRoom.GetRoomName(), "Ro");
        }

        [TestMethod]
        public void RoomNameMaxMinusOne()
        {
            RoomObj TestRoom = new RoomObj((255 - 1), "12345678901234567890123", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);
            Assert.AreEqual(TestRoom.GetRoomName(), "12345678901234567890123");
        }

        [TestMethod]
        public void RoomNameMax()
        {
            RoomObj TestRoom = new RoomObj((255), "123456789012345678901234", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);
            Assert.AreEqual(TestRoom.GetRoomName(), "123456789012345678901234");
        }

        [TestMethod]
        public void RoomNameMaxPlusOne()
        {
            RoomObj TestRoom = new RoomObj((255 + 1), "1234567890123456789012345", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);
            Assert.AreEqual(TestRoom.GetRoomName(), "1234567890123456789012345");
        }

        [TestMethod]
        public void RoomNameExtremeMax()
        {
            RoomObj TestRoom = new RoomObj((2147483647), "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ.", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);
            Assert.AreEqual(TestRoom.GetRoomName(), "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ.");
        }

        // Room Name //

        [TestMethod]
        public void RoomDescExtremeMin()
        {
            RoomObj TestRoom = new RoomObj(-2147483648, "Room Name", "", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomDesc(), "");
        }


        [TestMethod]
        public void RoomDescMin()
        {
            RoomObj TestRoom = new RoomObj(0, "Room Name", "A", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomDesc(), "A");
        }

        [TestMethod]
        public void RoomDescMinPlusOne()
        {
            RoomObj TestRoom = new RoomObj(0, "Room Name", "A ", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomDesc(), "A ");
        }

        [TestMethod]
        public void RoomDescMaxMinusOne()
        {
            RoomObj TestRoom = new RoomObj(0, "Room Name", "34567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomDesc(), "34567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901");
        }

        [TestMethod]
        public void RoomDescMax()
        {
            RoomObj TestRoom = new RoomObj(0, "Room Name", "123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomDesc(), "123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890");
        }

        [TestMethod]
        public void RoomDescMaxPlusOne()
        {
            RoomObj TestRoom = new RoomObj(0, "Room Name", "1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomDesc(), "1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901");
        }

        [TestMethod]
        public void RoomDescExtremeMax()
        {
            RoomObj TestRoom = new RoomObj(0, "Room Name", "123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomDesc(), "123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890");
        }

        // Hour

        [TestMethod]
        public void HourExtremeMin()
        {
            try
            {
                RoomObj TestRoom = new RoomObj(-2147483648, "Room Name", "A description of the room which can be null in the database", new TimeSpan(-2145755, -2145755, -2145755), new TimeSpan(-2145755, -2145755, -2145755), true);
                Assert.Fail();
            }
            catch (Exception)
            {

            }
        }

        [TestMethod]
        public void HourMinMinusOne()
        {
            try
            {
                RoomObj TestRoom = new RoomObj(0, "Room Name", "A description of the room which can be null in the database", new TimeSpan(-1, -1, -1), new TimeSpan(-2145755, -2145755, -2145755), true);
                Assert.Fail();
            }
            catch (Exception)
            {

            }
        }

        [TestMethod]
        public void HourMin()
        {
            RoomObj TestRoom = new RoomObj(0, "Room Name", "A description of the room which can be null in the database", new TimeSpan(0, 0, 0), new TimeSpan(0, 0, 0), true);

            Assert.AreEqual(TestRoom.GetOpenHour(), "00:00:00");
        }

        [TestMethod]
        public void HourMinPlusOne()
        {
            RoomObj TestRoom = new RoomObj(0, "Room Name", "A description of the room which can be null in the database", new TimeSpan(0, 0, 01), new TimeSpan(0, 0, 01), true);

            Assert.AreEqual(TestRoom.GetOpenHour(), "00:00:01");
        }

        [TestMethod]
        public void HourMaxMinusOne()
        {
            RoomObj TestRoom = new RoomObj(0, "Room Name", "A description of the room which can be null in the database", new TimeSpan(23, 59, 58), new TimeSpan(23, 59, 58), true);

            Assert.AreEqual(TestRoom.GetOpenHour(), "23:59:58");
        }

        [TestMethod]
        public void HourMax()
        {
            RoomObj TestRoom = new RoomObj(0, "Room Name", "A description of the room which can be null in the database", new TimeSpan(23, 59, 59), new TimeSpan(23, 59, 59), true);

            Assert.AreEqual(TestRoom.GetOpenHour(), "23:59:59");
        }

        [TestMethod]
        public void HourMaxPlusOne()
        {
            try
            {
                RoomObj TestRoom = new RoomObj(0, "Room Name", "A description of the room which can be null in the database", new TimeSpan(24, 00, 00), new TimeSpan(24, 00, 00), true);
                Assert.Fail();
            }
            catch (Exception)
            {

            }
        }

        [TestMethod]
        public void HourExtremeMax()
        {
            try
            {
                RoomObj TestRoom = new RoomObj(0, "Room Name", "A description of the room which can be null in the database", new TimeSpan(26359, 26359, 26359), new TimeSpan(26359, 26359, 26359), true);
                Assert.Fail();
            }
            catch (Exception)
            {

            }
        }

        // available

        [TestMethod]
        public void AvailableTrue()
        {
            RoomObj TestRoom = new RoomObj(0, "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetAvailable(), true);
        }

        [TestMethod]
        public void AvailableFalse()
        {
            RoomObj TestRoom = new RoomObj(0, "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), false);

            Assert.AreEqual(TestRoom.GetAvailable(), false);
        }
    }
}
