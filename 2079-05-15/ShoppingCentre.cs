public class ShoppingCentre:CommercialBuildings , IAppointmentManager , IEventManager
{
    public new int NumofSpaceLeft {get;set;}=50;
    public void BookAppointment()
    {
        Console.WriteLine($"Appointment booked for {GetLocation()}");

    }
    public void ManageNewEvent()
    {
        Console.WriteLine($"New Event organized for {GetLocation()}");

    }
    public override string GetLocation()
    {
        return "Location: " + base.GetLocation();
    }
    public override string GetBusinessPermit()
    {
        return "Legal Permit Granted";

    }
}