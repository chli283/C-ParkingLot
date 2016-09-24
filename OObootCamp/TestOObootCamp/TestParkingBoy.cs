using System;
using OObootCamp;
using Xunit;


namespace TestOObootCamp
{
    public class TestParkingBoy
    {
        [Fact]
        public void should_be_able_to_pick_the_same_car_when_parking_lot_park_a_car()
        {
            ParkingLot lot = new ParkingLot(1);
            ParkingBoy boy = new ParkingBoy(lot);
            int ticket = lot.park("Land Rover");
            Assert.Same("Land Rover",boy.pick(ticket));
        }

     
        [Fact]
        public void should_be_able_to_pick_the_same_car_when_parking_boy_park_a_car()
        {
            ParkingLot lot = new ParkingLot(1);
            ParkingBoy boy = new ParkingBoy(lot);
            int ticket = boy.park("Land Rover");
            Assert.Same("Land Rover",boy.pick(ticket));
        }

        [Fact]
        public void should_be_able_to_pick_correct_car_when_custom_park_multi_diff_cars()
        {
            ParkingLot lot = new ParkingLot(3);
            ParkingBoy boy = new ParkingBoy(lot);
            int ticketA = boy.park("BMW");
            int ticketB = boy.park("Land Rover");
            int ticketC = boy.park("porsche");

            Assert.Same("Land Rover", boy.pick(ticketB));
            Assert.Same("porsche", boy.pick(ticketC));
            Assert.Same("BMW", boy.pick(ticketA));

        }
        [Fact]
        public void should_not_support_to_pick_the_same_car_repeatly_when_custom_pick_car()
        {
            ParkingLot lot = new ParkingLot(1);
            ParkingBoy boy = new ParkingBoy(lot);
            int ticket = boy.park("Volkswagen");
            boy.pick(ticket);
            Assert.Null(boy.pick(ticket));

        }

        [Fact]
         public void should_be_able_to_reject_parking_car_when_custome_park_car_to_full_parking_lot()
        {
            ParkingLot lot = new ParkingLot(2);
            ParkingBoy boy = new ParkingBoy(lot);
            boy.park("Mustang");
            boy.park("parsche");
            Assert.Throws<Exception>(()=>boy.park("Ferrari"));

        }

        [Fact]
        public void should_be_able_to_park_car_after_custome_pick_car_from_full_parking_lot()
        {
            ParkingLot lot = new ParkingLot(1);
            ParkingBoy boy = new ParkingBoy(lot);
            int ticket1 = boy.park("Mustang");
            boy.pick(ticket1);
            int ticket2 = boy.park("Ferrari");
            Assert.Equal("Ferrari", boy.pick(ticket2));
        }


    }
}
