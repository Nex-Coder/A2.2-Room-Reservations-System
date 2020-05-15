using System;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoomManagementSystems;

namespace RoomManagementTest
{
    [TestClass]
    public class RoomObjCollectionTest
    {
        [TestMethod]
        public void RoomObjCollectionListOK() // Not null test basically.
        {
            DataTable TestData = RoomObjCollection.List();
            Assert.AreNotEqual(TestData, null);
        }

        // More tests not available as it will minipulate the data in our database. These tests are done on the server itself for extremes of data among other things and exceptions are handle on the Management System level.
    }
}
