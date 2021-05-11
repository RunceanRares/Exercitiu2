namespace Exercitiul2
{
    public class SuvBuilder : IVehicleBuilder
    {
        Vehicle objVehicle = new Vehicle();
        public void SetModel()
        {
            objVehicle.Model = "SUV";
        }

        public void SetEngine()
        {
            objVehicle.Engine = "3.0TFSI";
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
