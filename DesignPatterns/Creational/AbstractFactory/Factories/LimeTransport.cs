
using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicle;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.Factories
{
    public class LimeTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Drone();
        }

        public ILandVehicle CreateTransportVehicle()
        {
            return new Scooter();
        }
    }
}
