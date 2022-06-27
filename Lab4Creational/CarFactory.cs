using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Creational
{
    public class CarFactory
    {
        public Car Build(CarBuilder builder)
        {
            builder.MakeName();
            builder.MakeExterior();
            builder.MakeInterior();
            builder.MakeComfort();
            builder.MakeSafety();
            builder.MakeMedia();
            return builder.GetCar();
        }
    }
}
