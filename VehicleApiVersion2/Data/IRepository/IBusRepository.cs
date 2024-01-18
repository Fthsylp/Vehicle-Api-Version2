using VehicleApiVersion2.Models;

namespace VehicleApiVersion2.Data.IRepository
{
    public interface IBusRepository
    {
        Bus getBusByColor(string color);
    }
}
