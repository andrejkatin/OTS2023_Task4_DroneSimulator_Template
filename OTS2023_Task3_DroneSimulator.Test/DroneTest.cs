using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_Task3_DroneSimulator.Test
{
    public class DroneTest
    {
        private Drone drone;

        [SetUp]
        public void SetUp()
        {
            int[] coordinates = { 30, 0, 30 };
            int[] boundaries = { 50, 50, 50 };
            drone = new Drone(coordinates, boundaries);
        }

        [Test]
        public void Drone_MoveUp_SuccessfullMovingUp()
        {
            // ARRANGE
            int expectedYCoordinate = 1;

            // ACT
            drone.MoveUp();

            // ASSERT
            Assert.AreEqual(expectedYCoordinate, drone.coordinates[1]);
        }

        [TearDown]
        public void TearDown()
        {
            drone = null;
        }
    }
}
