namespace Exercitiul2
{
    public class CrossoverBuilder : IVehicleBuilder
    {
        Vehicle objVehicle = new Vehicle();
        public void SetModel()
        {
            objVehicle.Model = "Crossover";
        }

        public void SetEngine()
        {
            objVehicle.Engine = Engine.Benzine.ToString() ;
        }

        public void SetColor()
        {
            objVehicle.Color = "Green";
        }



        public void SetAccessories()
        {
            objVehicle.Accessories.Add("heated steering wheel");

        }

        public Vehicle GetVehicle()
        {
            return objVehicle;
        }
    }
}
