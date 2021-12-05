using System;


namespace FactoryMethod.Vehicles
{
    class Bike : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pacote Coletado!");
        }

        public void StartRoute()
        {
            Console.WriteLine("Entrega a Caminho!");
        }
    }
}
