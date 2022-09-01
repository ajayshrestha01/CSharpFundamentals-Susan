public class Program
{
    public static void Main()
    {
        var PP = new PartyPalace();
        Console.WriteLine($"Party palace has {PP.NumofSpaceLeft} spaces left to rent");
        Console.WriteLine($"Party palace is located in : {PP.GetLocation()}");
        Console.WriteLine($"Party palace has business permit of : {PP.GetBusinessPermit()}");
        PP.ManageNewEvent();
        



        var SC = new ShoppingCentre();
        Console.WriteLine($"Shopping Centre has {SC.NumofSpaceLeft} spaces left to rent");
        Console.WriteLine($"Shopping Centre is located in : {SC.GetLocation()}");
        Console.WriteLine($"Shopping Centre has business permit of : {SC.GetBusinessPermit()}");
        SC.ManageNewEvent();
        SC.BookAppointment();
        Console.WriteLine();



        var AP = new Apartment();
        AP.BookAppointment();
        Console.WriteLine($"Apartment is located in {AP.GetBuildingAddress()}");
        Console.WriteLine();


    }
}

