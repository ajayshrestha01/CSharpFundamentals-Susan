public class Vehicle1
{
    public string VNumber { get; set; } = "N/A";
    public float Mileage { get; set; }
    public double load;

    public void Print()
    {
        var vehicleinfo = $"Plate: {VNumber} \nMileage {Mileage} km/ltr \nCapacity: {load} tons";
        Console.Write(vehicleinfo);
    }
}
