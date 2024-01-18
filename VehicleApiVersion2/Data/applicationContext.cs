using VehicleApiVersion2.Models;

namespace VehicleApiVersion2.Data
{
    public  class applicationContext
    {
        public  List<Car> Cars { get; set; }
        public  List<Bus> Buses { get; set; }
        public  List<Boat> Boats { get; set; }

        public applicationContext()
        {
            Cars = new List<Car>()
            {
                new Car() {Id = 1, Color = "Red", Wheels = 4, Headlights = "Off" },
                new Car() {Id = 2, Color = "Black", Wheels = 4, Headlights = "Off" },
                new Car() {Id = 3, Color = "White", Wheels = 4, Headlights = "Off" },
            };
            Buses = new List<Bus>()
            { 
                new Bus() {Id = 1, Color = "Red"},
                new Bus() {Id = 2, Color = "Black"},
                new Bus() {Id = 3, Color = "White"},
            };
            Boats = new List<Boat>()
            {
                new Boat() {Id = 1, Color = "Red"},
                new Boat() {Id = 2, Color = "Black"},
                new Boat() {Id = 3, Color = "White"},
            };
        }

    }
}
