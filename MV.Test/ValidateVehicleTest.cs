using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MV.Prometric.Entities;

namespace MV.Test
{
    [TestClass]
    public class ValidateVehicleTest
    {
        [TestMethod]
        public void Validate_NoWheels_For4Wheels_ShouldSucceed()
        {
            //arrange
            bool expected = true;
            var vehicle = new Bus { VehicleType = 3, Noofwheels = 4 };
            //act

            var result = vehicle.Validate();

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Validate_NoWheels_For4Wheels_ShouldFail()
        {
            //arrange
            bool expected = false;
            var vehicle = new Bus { VehicleType = 3, Noofwheels = 3 };
            //act

            var result = vehicle.Validate();

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void GetFuelEfficiency_ForBicycle_ShouldreturnNA()
        {
            //arrange
            string expected = "N/A";
            var vehicle = new Bicycle { VehicleType = 2, Noofwheels = 2 };
            //act

            var result = vehicle.FuelEfficiencyText();

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void GetFuelEfficiency_ForNonBicycle_ShouldreturnActualValue()
        {
            //arrange
            string expected = "10";
            var vehicle = new Boat { VehicleType = 1, Noofwheels = 2,FuelEfficiency = 10,Passengers=2 };
            //act

            var result = vehicle.FuelEfficiencyText();

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void Calculate_FuelEfficiencyPerPassenger_whenZeroPassangers_ShouldReturnZero()
        {
            //arrange
            int expected = 0;
            var vehicle = new Bus { VehicleType = 3, Noofwheels = 3,Passengers = 0, FuelEfficiency = 10 };
            //act

            Assert.AreEqual(expected, vehicle.FuelEfficientPerPassenger);

        }

        [TestMethod]
        public void Calculate_FuelEfficiencyPerPassenger_whenZeroPassangers_ShouldbeGreaterThanZero()
        {
            //arrange
            int expected = 5;
            var vehicle = new Bus { VehicleType = 3, Noofwheels = 3, Passengers = 2,FuelEfficiency =10 };
            //act

            Assert.AreEqual(expected, vehicle.FuelEfficientPerPassenger);

        }

    }
}
