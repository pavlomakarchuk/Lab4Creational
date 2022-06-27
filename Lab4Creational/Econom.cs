using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Creational
{
    public class Econom : CarBuilder
    {
        public override void MakeName()
        {
            _car.Name = "Deo Lanos";
        }
        public override void MakeExterior()
        {
            _car.Exterior = "White paint";
        }
        public override void MakeInterior()
        {
            _car.Interior = "Plastic";
        }
        public override void MakeComfort()
        {
            _car.Comfort = "No comfort";
        }
        public override void MakeSafety()
        {
            _car.Safety = "Belts";
        }
        public override void MakeMedia()
        {
            _car.Media = "Old radio";
        }
    }
}
