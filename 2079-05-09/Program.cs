Appointment A = new();
var FullName = A.Name("Susan", "Sharma");
Console.WriteLine($"Patient's Name: {FullName}");

var Schedule = A.DisplaySchedule();
Console.WriteLine($"Appointment Schedule: {Schedule}");
var DoctorName = A.Name("Saurav", "Dahal", "Dr", "M.S");
Console.WriteLine($"Doctor's Details:{DoctorName}");









