using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Creational
{
    public class Sclass : CarBuilder

    {
        public override void MakeName()
        {
            _car.Name = "Mercedes s500";
        }
        public override void MakeExterior()
        {
            _car.Exterior = "Black paint";
        }
        public override void MakeInterior()
        {
            _car.Interior = "Leather";
        }
        public override void MakeComfort()
        {
            _car.Comfort = "Conditioner";
        }
        public override void MakeSafety()
        {
            _car.Safety = "Airbags";
        }
        public override void MakeMedia()
        {
            _car.Media = "5 speakers";
        }
    }
}
