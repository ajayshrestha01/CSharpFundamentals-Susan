public class PartyPalace: CommercialBuildings, IEventManager
{
    public void ManageNewEvent()
    {
        Console.WriteLine($"New Event Created for {GetLocation()}");
    }
    

    public override string GetBusinessPermit()
    {
        return "Legal Permit Granted";
        
    }
}