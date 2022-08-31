class Appointment


{

    public string Name(string firstName, string lastName)
    {
        string FullName = $"{firstName} {lastName}";
        return FullName;
    }
    public DateTime DisplaySchedule()
    {
        return DateTime.Now.AddDays(2);
    }

    public string Name(string firstName, string lastName, string salutation, string degree)
    {
        string DoctorDetails = $" {salutation}. {firstName} {lastName}, {degree}";
        return DoctorDetails;

    }

}