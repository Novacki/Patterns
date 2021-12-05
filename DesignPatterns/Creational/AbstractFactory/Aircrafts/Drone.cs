using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    public class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Ventos a 30km, sudeste, ventos ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("ligando helices.");
        }

        public void StartRoute()
        {
            GetCargo();
            CheckWind();
            Console.WriteLine("Iniciando a entrega.");
        }
    }
}
