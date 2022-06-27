using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Creational
{
    public abstract class CarBuilder
    {
        protected readonly Car _car = new Car();
        public abstract void MakeName();
        public abstract void MakeExterior();
        public abstract void MakeInterior();
        public abstract void MakeComfort();
        public abstract void MakeSafety();
        public abstract void MakeMedia();

        public virtual Car GetCar() => _car;
    }
}
