using Microsoft.AspNetCore.Mvc;
using VehicleApiVersion2.Data.IRepository;
using VehicleApiVersion2.Models;

namespace VehicleApiVersion2.Data.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly applicationContext dbContext;

        public CarRepository(applicationContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Car deleteCar(int id)
        {
            var existingCar = dbContext.Cars.FirstOrDefault(c => c.Id == id);
            if (existingCar != null) 
            {
                dbContext.Cars.Remove(existingCar);
            }
            return null;
        }

        public List<Car> getAllCars()
        {
            return dbContext.Cars.ToList();
        }

        public Car getCarByColor(string color)
        {
            var existingCar = dbContext.Cars.FirstOrDefault(c => c.Color == color);
            return existingCar;
        }

        public Car headlightsTurner(int id)
        {
            var existingCar = dbContext.Cars.FirstOrDefault(c => c.Id == id);
            existingCar.Headlights = existingCar.Headlights == "Off" ? existingCar.Headlights = "On" : existingCar.Headlights = "Off";
            return existingCar;
        }
    }
}
