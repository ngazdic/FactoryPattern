using FactoryPattern;

Console.WriteLine("What kind of vehicle do you want to drive? 4 for car 2 for Motorcycle");

string userVehicle = Console.ReadLine();


IVehicle vehicle = VehicleFactory.GetVehicle(userVehicle);

vehicle.Drive();