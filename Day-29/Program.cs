using System;
using System.Collections.Generic;

namespace AeroCook
{
    abstract class KitchenAppliance
    {
        public string ModelName { get; set; }
        public int PowerConsumption { get; set; }

        public KitchenAppliance(string modelName, int power)
        {
            ModelName = modelName;
            PowerConsumption = power;
        }

        public abstract void Cook();
        public virtual void Preheat()
        {
            Console.WriteLine($"{ModelName}: No preheating required.");
        }
    }

    interface ITimer
    {
        void SetTimer(int minutes);
    }

    interface IWifiEnabled
    {
        void ConnectToWifi(string networkName);
    }

    class Microwave : KitchenAppliance, ITimer
    {
        public Microwave(string modelName, int power)
            : base(modelName, power)
        {
        }

        public void SetTimer(int minutes)
        {
            Console.WriteLine($"{ModelName}: Timer set for {minutes} minutes.");
        }

        public override void Cook()
        {
            Console.WriteLine($"{ModelName}: Heating food using microwave radiation.");
        }
    }

    class ElectricOven : KitchenAppliance, ITimer, IWifiEnabled
    {
        public ElectricOven(string modelName, int power)
            : base(modelName, power)
        {
        }

        public void SetTimer(int minutes)
        {
            Console.WriteLine($"{ModelName}: Oven timer set for {minutes} minutes.");
        }

        public void ConnectToWifi(string networkName)
        {
            Console.WriteLine($"{ModelName}: Connected to WiFi network '{networkName}'.");
        }

        public override void Preheat()
        {
            Console.WriteLine($"{ModelName}: Preheating to required temperature...");
        }

        public override void Cook()
        {
            Preheat();
            Console.WriteLine($"{ModelName}: Baking food evenly.");
        }
    }

    class AirFryer : KitchenAppliance
    {
        public AirFryer(string modelName, int power)
            : base(modelName, power)
        {
        }

        public override void Cook()
        {
            Console.WriteLine($"{ModelName}: Cooking quickly using rapid hot air circulation.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<KitchenAppliance> appliances = new List<KitchenAppliance>
            {
                new Microwave("MicroX100", 1200),
                new ElectricOven("OvenPro500", 2500),
                new AirFryer("AirCrisp200", 1500)
            };

            Console.WriteLine("=== Cooking Process ===");

            foreach (var appliance in appliances)
            {
                appliance.Cook();
                Console.WriteLine();
            }

            Console.WriteLine("=== WiFi Test ===");

            foreach (var appliance in appliances)
            {
                if (appliance is IWifiEnabled wifiDevice)
                {
                    wifiDevice.ConnectToWifi("Home_Network");
                }
                else
                {
                    Console.WriteLine($"{appliance.ModelName}: No WiFi capability.");
                }
            }
        }
    }
}