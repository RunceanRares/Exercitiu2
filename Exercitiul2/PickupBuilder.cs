using System;
using System.Collections.Generic;
using System.Text;

namespace Exercitiul2
{
    public class PickupBuilder: IVehicleBuilder
    {
        Vehicle objVehicle = new Vehicle();
        public void SetModel()
        {
            objVehicle.Model = "Pickup";
        }

        public void SetEngine()
        {
            objVehicle.Engine = Engine.Disel.ToString();
        }

        public void SetColor()
        {
            objVehicle.Color = "GREY";
        }


        public void SetAccessories()
        {
            objVehicle.Accessories.Add("Leather steering wheel");
        }

        public Vehicle GetVehicle()
        {
            return objVehicle;
        }
    }
}
