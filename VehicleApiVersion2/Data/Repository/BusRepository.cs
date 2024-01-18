using VehicleApiVersion2.Data.IRepository;
using VehicleApiVersion2.Models;

namespace VehicleApiVersion2.Data.Repository
{
    public class BusRepository:IBusRepository
    {
        private readonly applicationContext appContext;

        public BusRepository(applicationContext appContext)
        {
            this.appContext = appContext;
        }

        public Bus getBusByColor(string color)
        {
            var existingBus = appContext.Buses.FirstOrDefault(b => b.Color == color);
            return existingBus;
        }
    }
}
