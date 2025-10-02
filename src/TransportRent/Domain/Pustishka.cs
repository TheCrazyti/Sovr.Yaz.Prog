using Domain.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class Pustishka
    {
        public Pustishka() 
        {
            TransportType auto = TransportType.FromName("Автомобиль");
            TransportType automobile = new Auto();
            TransportType Samokat = TransportType.FromName("Самокат");
            TransportType Sam = new Samokat();
            TransportType Velos = TransportType.FromName("Велосипед");
            TransportType Velosiped = new Velos();
        }
    }
}
