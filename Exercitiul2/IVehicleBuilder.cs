namespace Exercitiul2
{
    public interface IVehicleBuilder
    {
        void SetModel();
        void SetEngine();
        void SetColor();
    
        void SetAccessories();

        Vehicle GetVehicle();
    }
}
