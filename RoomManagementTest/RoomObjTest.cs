using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoomManagementSystems;

namespace RoomManagementTest
{
    [TestClass]
    public class RoomObjTest
    {
        // RoomObj tests.
        [TestMethod]
        public void RoomObjOk()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj(100, "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.IsNotNull(TestRoom);
        }

        [TestMethod]
        public void RoomIDExtremeMin()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj(-2147483648, "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomID(), -2147483648);
        }

        [TestMethod]
        public void RoomIDMinMinusOne()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj((0 - 1), "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomID(), -1);
        }

        [TestMethod]
        public void RoomIDMin()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj(0, "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomID(), 0);
        }

        [TestMethod]
        public void RoomIDMinPlusOne()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj((0 + 1), "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomID(), 1);
        }

        [TestMethod]
        public void RoomIDMaxMinusOne()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj((255 - 1), "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomID(), 254);
        }

        [TestMethod]
        public void RoomIDMax()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj((255), "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomID(), 255);
        }

        [TestMethod]
        public void RoomIDMaxPlusOne()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj((255 + 1), "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomID(), 256);
        }

        [TestMethod]
        public void RoomIDExtremeMax()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj((2147483647), "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomID(), 2147483647);
        }

        [TestMethod]
        public void RoomNameExtremeMin()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj(0, "", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);
            Assert.AreEqual(TestRoom.GetRoomName(), "");
        }

        [TestMethod]
        public void RoomNameMinMinusOne()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj((0 - 1), "", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);
            Assert.AreEqual(TestRoom.GetRoomName(), "");
        }

        [TestMethod]
        public void RoomNameMin()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj(0, "R", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);
            Assert.AreEqual(TestRoom.GetRoomName(), "R");
        }

        [TestMethod]
        public void RoomNameMinPlusOne()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj((0 + 1), "Ro", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);
            Assert.AreEqual(TestRoom.GetRoomName(), "Ro");
        }

        [TestMethod]
        public void RoomNameMaxMinusOne()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj((255 - 1), "12345678901234567890123", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);
            Assert.AreEqual(TestRoom.GetRoomName(), "12345678901234567890123");
        }

        [TestMethod]
        public void RoomNameMax()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj((255), "123456789012345678901234", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);
            Assert.AreEqual(TestRoom.GetRoomName(), "123456789012345678901234");
        }

        [TestMethod]
        public void RoomNameMaxPlusOne()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj((255 + 1), "1234567890123456789012345", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);
            Assert.AreEqual(TestRoom.GetRoomName(), "1234567890123456789012345");
        }

        [TestMethod]
        public void RoomNameExtremeMax()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj((2147483647), "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ.", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);
            Assert.AreEqual(TestRoom.GetRoomName(), "ABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZABCDEFGHIJKLMNOPQRSTUVWXYZ.");
        }

        // Room Name //

        [TestMethod]
        public void RoomDescExtremeMin()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj(-2147483648, "Room Name", "", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomDesc(), "");
        }


        [TestMethod]
        public void RoomDescMin()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj(0, "Room Name", "A", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomDesc(), "A");
        }

        [TestMethod]
        public void RoomDescMinPlusOne()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj(0, "Room Name", "A ", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomDesc(), "A ");
        }

        [TestMethod]
        public void RoomDescMaxMinusOne()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj(0, "Room Name", "34567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomDesc(), "34567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901");
        }

        [TestMethod]
        public void RoomDescMax()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj(0, "Room Name", "123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomDesc(), "123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890");
        }

        [TestMethod]
        public void RoomDescMaxPlusOne()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj(0, "Room Name", "1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomDesc(), "1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901");
        }

        [TestMethod]
        public void RoomDescExtremeMax()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj(0, "Room Name", "123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetRoomDesc(), "123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890");
        }

        // Hour

        [TestMethod]
        public void HourExtremeMin()
        {
            try
            {
                // A test of the most typical data to see if the roomObj can be declared OK.
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
                // A test of the most typical data to see if the roomObj can be declared OK.
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

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj(0, "Room Name", "A description of the room which can be null in the database", new TimeSpan(0, 0, 0), new TimeSpan(0, 0, 0), true);

            Assert.AreEqual(TestRoom.GetOpenHour(), "00:00:00");
        }

        [TestMethod]
        public void HourMinPlusOne()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj(0, "Room Name", "A description of the room which can be null in the database", new TimeSpan(0, 0, 01), new TimeSpan(0, 0, 01), true);

            Assert.AreEqual(TestRoom.GetOpenHour(), "00:00:01");
        }

        [TestMethod]
        public void HourMaxMinusOne()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj(0, "Room Name", "A description of the room which can be null in the database", new TimeSpan(23, 59, 58), new TimeSpan(23, 59, 58), true);

            Assert.AreEqual(TestRoom.GetOpenHour(), "23:59:58");
        }

        [TestMethod]
        public void HourMax()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj(0, "Room Name", "A description of the room which can be null in the database", new TimeSpan(23, 59, 59), new TimeSpan(23, 59, 59), true);

            Assert.AreEqual(TestRoom.GetOpenHour(), "23:59:59");
        }

        [TestMethod]
        public void HourMaxPlusOne()
        {
            try
            {
                // A test of the most typical data to see if the roomObj can be declared OK.
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
                // A test of the most typical data to see if the roomObj can be declared OK.
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

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj(0, "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), true);

            Assert.AreEqual(TestRoom.GetAvailable(), true);
        }

        [TestMethod]
        public void AvailableFalse()
        {

            // A test of the most typical data to see if the roomObj can be declared OK.
            RoomObj TestRoom = new RoomObj(0, "Room Name", "A description of the room which can be null in the database", new TimeSpan(12, 0, 0), new TimeSpan(18, 0, 0), false);

            Assert.AreEqual(TestRoom.GetAvailable(), false);
        }
        // End of RoomObj testing
    }
}
