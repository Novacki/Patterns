using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.Factories
{
    public interface ITransportFactory
    {

        ILandVehicle CreateTransportVehicle();
        IAircraft CreateTransportAircraft();

    }
}
