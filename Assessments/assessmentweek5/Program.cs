// See https://aka.ms/new-console-template for more information

using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;
using System.Xml.Linq;
interface ILoggable
{
    public void SaveLog(string message);
}
public class RestrictedDestinationException: Exception
{
    public string DeniedLocation { get; }
    public RestrictedDestinationException(string location): base($"Restricted destination : {location}")
    {
        DeniedLocation = location;
    }
}
public class InsecurePackagingException: Exception
{
    public InsecurePackagingException(string message): base(message)
    {
        
    }
}
class LogManager: ILoggable
{
    public void SaveLog(string message)
    {
        string file = "shipment_audit.log";
        if (!File.Exists(file))
        {
            System.Console.WriteLine("file does not exists");
            return;
        }
        using StreamWriter sw = new StreamWriter(file, true);
        sw.WriteLine($"{DateTime.Now}: {message}");
    }

}
abstract class Shipment
{
    public string TrackingId { get; set; }
    public double Weight { get; set; }
    public string Destination { get; set; }

    public Shipment(string trackingId, double weight,string destination)
    {
        TrackingId = trackingId;
        Weight = weight;
        Destination = destination;
    }
    

    public abstract void ProcessShipment();
} 

class ExpressShipment: Shipment
{
    public ExpressShipment(string trackingId, double weight,string destination): base(trackingId, weight, destination)
    {
        
    }
    public override void ProcessShipment()
    {
        if(Destination == "North Pole" || Destination == "Unknown Island")
        {
            throw new RestrictedDestinationException(Destination);
        }
        
        if (Weight <= 0)
        {
            throw ( new ArgumentOutOfRangeException("Data entry error"));
        }
        if (Weight > 1000)
        {
            throw new Exception("Heavy lift permit required");
        }      
    }
}
class HeavyFreight: Shipment
{
    public bool IsFragile { get; set; }
    public bool IsReinforced { get; set; }
    public bool IsHeavyLiftPermit { get; set; }
    public HeavyFreight(string trackingId, double weight,string destination,bool isfragile,bool isreinforced,bool isheavyLiftPermit): base (trackingId, weight, destination)
    {
        IsFragile = isfragile;
        IsHeavyLiftPermit = isheavyLiftPermit;
        IsReinforced = isreinforced;
    }
    
    public override void ProcessShipment()
    {
        if (Weight <= 0)
        {
            throw new ArgumentOutOfRangeException();
        }
    
        if (Destination == "North Pole" || Destination == "Unknown Island")
        {
            throw new RestrictedDestinationException(Destination);
        }

        if (Weight > 1000 && !IsHeavyLiftPermit){
            throw new Exception("Heavy lift permit required");
        }

        if (IsFragile && !IsReinforced)
        {
            throw new InsecurePackagingException("Fragile shipment not reinforced");
        }
        Console.WriteLine($"Heavy freight processed: {TrackingId}");
    }
}
class ImplementationClass
{
    public static void Main(string[] args)
    {

        ExpressShipment s1 = new ExpressShipment("TRACK01",3000,"Australia");
        ExpressShipment s2 = new ExpressShipment("TRACK03", 100, "North Pole");
        HeavyFreight s3 = new HeavyFreight("TRACK04",2000, "US", false, false, true);
        HeavyFreight s4 = new HeavyFreight("TRACK02", 1001, "Canada", false, false, false);
        HeavyFreight s5 = new HeavyFreight("TRACK05",200, "US", true, true, false);
        HeavyFreight s6 = new HeavyFreight("TRACK05",1900, "Greece", false, true, false);

        List<Shipment> shipments = new List<Shipment>(){s1,s2,s3,s4,s5,s6};
        // shipments.Add(s1);
        // shipments.Add(s2);
        // shipments.Add(s3);
        // shipments.Add(s4);
        // shipments.Add(s5);
        // shipments.Add(s6);
        
        LogManager manager = new LogManager();
        foreach(var ship in shipments)
        {
            try
            {
                ship.ProcessShipment();
                manager.SaveLog($"SUCCESS: {ship.TrackingId}");
                
            }
            catch(RestrictedDestinationException ex)
            {
                manager.SaveLog(ex.Message);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                manager.SaveLog(ex.Message);
            }
            catch(Exception ex)
            {
                manager.SaveLog(ex.Message);
            }
            finally
            {
                System.Console.WriteLine($"Processing attempt finished for ID {ship.TrackingId}");
            }
        }
    }
}