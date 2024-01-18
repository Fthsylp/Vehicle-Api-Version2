using VehicleApiVersion2.Models;

namespace VehicleApiVersion2.Data.IRepository
{
    public interface IBoatRepository
    {
        Boat getBoatByColor(string color);
    }
}
