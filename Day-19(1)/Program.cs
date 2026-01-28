// See https://aka.ms/new-console-template for more information


using System.Diagnostics;

class Polymorphism
{
    abstract class Vehicle
    {
        public string ModelName { get; set; }
        public Vehicle(string modelName)
        {
            ModelName = modelName;
        }
        public abstract void Move();
        public virtual string GetFuelStatus()
        {
            return "Fuel level is stable";
        }
    }
    class ElectricCar: Vehicle
    {
        public ElectricCar(string ModelName)
        :base( ModelName)
        {
            
        }
        public override void Move()
        {
            Console.WriteLine($"{ModelName} is gliding silently on battery power");

        }
        public override string GetFuelStatus()
        {
            
            return $"{ModelName} battery is at 80%";
        }
    }
    class HeavyTruck: Vehicle
    {
        public HeavyTruck(string ModelName)
        :base(ModelName)
        {
            
        }
        public override void Move()
        {
            Console.WriteLine($"{ModelName} is hauling cargo with high-torque diesel power");
        }
    }
    class CargoPlane: Vehicle
    {
        public CargoPlane(string ModelName)
        :base(ModelName)
        {
            
        }
        public override void Move()
        {
            Console.WriteLine($"{ModelName} is ascending at 30,000 feet");
        }
        public override string GetFuelStatus()
        {
            
            return base.GetFuelStatus() + " checking jet fuel reserves...";
        }
    }
    public static void Main()
    {
        Vehicle[] veh1 = new Vehicle[3]
        {
            new ElectricCar("ElectricCar"),
            new HeavyTruck("HeavyTruck"),
            new CargoPlane("CargoPlane")

        }; 
        for(int i= 0; i < 3; i++){
            veh1[i].Move();
            Console.WriteLine(veh1[i].GetFuelStatus());
        }
    }
}
