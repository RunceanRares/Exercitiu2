namespace Exercitiul2
{
    public class VehicleDirector
    {
        private readonly IVehicleBuilder objBuilder;

        public VehicleDirector(IVehicleBuilder builder)
        {
            objBuilder = builder;
        }

        public void CreateVehicle()
        {
            objBuilder.SetModel();
            objBuilder.SetEngine();
           
            objBuilder.SetColor();
            objBuilder.SetAccessories();
        }

        public Vehicle GetVehicle()
        {
            return objBuilder.GetVehicle();
        }
    }
}
