namespace Exercitiul2
{
    public class HatchbackBuilder : IVehicleBuilder
    {
        Vehicle objVehicle = new Vehicle();
        public void SetModel()
        {
            objVehicle.Model = "Hatchback";
        }

        public void SetEngine()
        {
            objVehicle.Engine = "1.2 DCI";
        }

        public void SetColor()
        {
            objVehicle.Color = "Red";
        }



        public void SetAccessories()
        {
            objVehicle.Accessories.Add("Navigation");

        }

        public Vehicle GetVehicle()
        {
            return objVehicle;
        }
    }
}
