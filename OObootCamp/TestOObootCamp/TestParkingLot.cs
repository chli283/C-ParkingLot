using OObootCamp;
using Xunit;

namespace TestOObootCamp
{
    public class TestParkingLot
    {
        [Fact]
        public void should_be_able_to_pick_same_car_to_tracy_when_tracy_park_car()
        {
            ParkingLot parkingLot = new ParkingLot();

            int ticket = parkingLot.park("paoche");

            Assert.Same("paoche", parkingLot.pick(ticket));
        }

        [Fact]
        public void should_be_able_to_pick_correct_car_when_custom_park_multi_diff_cars()
        {
            ParkingLot parkingLot = new ParkingLot();
            int ticketA = parkingLot.park("Baoma");
            int ticketB = parkingLot.park("luhu");
            int ticketC = parkingLot.park("baoshijie");

            Assert.Same("luhu", parkingLot.pick(ticketB));
            Assert.Same("baoshijie",parkingLot.pick(ticketC));
            Assert.Same("Baoma",parkingLot.pick(ticketA));

        }

        [Fact]
        public void should_be_able_to_reject_parking_car_when_custome_park_car_to_full_parking_lot()
        {

        }


    }
}
