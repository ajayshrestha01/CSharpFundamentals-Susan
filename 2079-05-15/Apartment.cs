public class Apartment : ResidentialBuildings, IAppointmentManager
{
    public void BookAppointment()
    {
        Console.WriteLine($"Appointment Booked for {GetBuildingAddress()}");

    }
    public new string GetBuildingAddress()
    {
        return "Ganeshthan, Chabahil";
       

    }

}

