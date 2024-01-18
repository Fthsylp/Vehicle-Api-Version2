namespace VehicleApiVersion2.Models
{
    public class Vehicle 
    {
        public int Id { get; set; }
        public string Color { get; set; }
    }
    public class Car : Vehicle
    {
        public int Wheels { get; set; }
        public string Headlights { get; set; }
    }
    public class Boat : Vehicle
    {

    }

    public class Bus : Vehicle
    {

    }
}
