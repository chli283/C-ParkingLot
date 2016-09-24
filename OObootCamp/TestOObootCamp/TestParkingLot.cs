using System;
using System.Data;
using OObootCamp;
using Xunit;
using Xunit.Sdk;

namespace TestOObootCamp
{
    public class TestParkingLot
    {
        [Fact]
        public void should_be_able_to_pick_same_car_to_tracy_when_tracy_park_car()
        {
            ParkingLot parkingLot = new ParkingLot();

            int ticket = parkingLot.park("porsche");

            Assert.Same("porsche", parkingLot.pick(ticket));
        }

        [Fact]
        public void should_be_able_to_pick_correct_car_when_custom_park_multi_diff_cars()
        {
            ParkingLot parkingLot = new ParkingLot();
            int ticketA = parkingLot.park("BMW");
            int ticketB = parkingLot.park("Land Rover");
            int ticketC = parkingLot.park("porsche");

            Assert.Same("Land Rover", parkingLot.pick(ticketB));
            Assert.Same("porsche",parkingLot.pick(ticketC));
            Assert.Same("BMW",parkingLot.pick(ticketA));

        }

        [Fact]
        public void should_not_support_to_pick_the_same_car_repeatly_when_custom_pick_car()
        {
            ParkingLot lot = new ParkingLot(1);
            int ticket =  lot.park("Volkswagen");
            lot.pick(ticket);
            Assert.Null(lot.pick(ticket));

        }

        [Fact]
        public void should_be_able_to_reject_parking_car_when_custome_park_car_to_full_parking_lot()
        {
            ParkingLot lot = new ParkingLot(2);
            lot.park("Mustang");
            lot.park("parsche");
            Assert.Throws<Exception>(()=>lot.park("Ferrari"));

        } 

        [Fact]
        public void should_be_able_to_park_car_after_custome_pick_car_from_full_parking_lot()
        {
            ParkingLot lot = new ParkingLot(1);
            int  ticket1 = lot.park("Mustang");
            lot.pick(ticket1);
            int ticket2 = lot.park("Ferrari");
            Assert.Equal("Ferrari",lot.pick(ticket2));
        }
 


    }
}
