namespace Exercitiul2
{
    public class SedanBuilder : IVehicleBuilder
    {
        Vehicle objVehicle = new Vehicle();
        public void SetModel()
        {
            objVehicle.Model = "Sedan";
        }

        public void SetEngine()
        {
            objVehicle.Engine = "1.9TDI";
        }

        public void SetColor()
        {
            objVehicle.Color = "Black";
        }

   

        public void SetAccessories()
        {
            objVehicle.Accessories.Add("Heated seats");
           
        }

        public Vehicle GetVehicle()
        {
            return objVehicle;
        }
    }
}
