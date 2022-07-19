using System;
namespace FactoryPattern
{
    public static class VehicleFactory
    {
        static VehicleFactory()
        {
        }

        public static IVehicle GetVehicle(string tires)
        {

            if (tires == "4")
            {
                return new Car();
            }
            if (tires == "2")
            {
                return new Motorcycle();
            }
            return new Car();
        }

    }

}
