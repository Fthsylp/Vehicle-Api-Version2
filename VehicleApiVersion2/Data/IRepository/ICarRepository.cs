using VehicleApiVersion2.Models;

namespace VehicleApiVersion2.Data.IRepository
{
    public interface ICarRepository
    {
        List<Car> getAllCars();
        Car getCarByColor(string color);
        Car headlightsTurner(int id);
        Car deleteCar(int id);
    }
}
