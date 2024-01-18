using VehicleApiVersion2.Data.IRepository;
using VehicleApiVersion2.Models;

namespace VehicleApiVersion2.Data.Repository
{
    public class BoatRepository : IBoatRepository
    {
        private readonly applicationContext appContext;

        public BoatRepository(applicationContext appContext)
        {
            this.appContext = appContext;
        }
        public Boat getBoatByColor(string color)
        {
            var existingBoat = appContext.Boats.FirstOrDefault(x => x.Color == color);
            return existingBoat;
        }
    }
}
