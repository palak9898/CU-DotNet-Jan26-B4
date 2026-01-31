// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

class StringPractice
{
    class OLADriver
    {
        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public string VehicleNo { get; set; }
        public List<Ride> Rides {get; set; } = new List<Ride>();

        public void AddRide(Ride ride)
        {
            Rides.Add(ride);
        }
        public int TotalFare()
        {
            int sum =0;
            foreach(var r in Rides)
            {
                sum += r.Fare;
            }
            return sum;
        }

        
    }
    class Ride
    {
        public int RideId { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public int Fare { get; set; }

        public Ride(int rideId, string to, string from, int fare)
        {
            RideId = rideId;
            To = to;
            From = from;
            Fare = fare;
        }

    }
    class OLAApp
    {
        public List<OLADriver> drivers { get; set; } = new List<OLADriver>();

        public void AddDriver(OLADriver driver)
        {
            drivers.Add(driver);
        }
        public void DisplayDriverWiseRide()
        {
            foreach(var d in drivers)
            {
                Console.WriteLine($"Driver name : {d.DriverName} Driver Vehicle : {d.VehicleNo} DriverId : {d.DriverId} ");
                foreach(var r in d.Rides)
                {
                    Console.WriteLine($"Fare : {r.Fare} From : {r.From} To {r.To}");
                }
            }
        }

    }
    static void Main(string[] args)
    {
        OLADriver driver1 = new OLADriver()
        {
            DriverId= 111,
            DriverName = "Vishu",
            VehicleNo = "PB65HH3456"
        };
        driver1.AddRide(new Ride(1,"Delhi", "Chandigarh", 2000));
        driver1.AddRide(new Ride(2,"Mumbai", "Delhi", 5000));

        OLADriver driver2 = new OLADriver()
        {
            DriverId= 112,
            DriverName = "Jindal",
            VehicleNo = "PB01HA1111"
        };
        driver2.AddRide(new Ride(3,"Mohali", "Chandigarh", 300));
        driver2.AddRide(new Ride(2,"Chandigarh", "Zirakpur", 700));

        OLAApp app = new OLAApp();
        app.AddDriver(driver1);
        app.AddDriver(driver2);

        app.DisplayDriverWiseRide();


        
    }
}
