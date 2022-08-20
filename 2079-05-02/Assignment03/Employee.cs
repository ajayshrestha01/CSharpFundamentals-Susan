public class Employee
{
    public string firstName;
    public string lastName;
    public byte employeeID;
    public bool isMale;
    public string department;
    public int hoursWorked;
    public bool isWorking;


    public void work()
    {
Console.WriteLine($"{firstName} is working.");
hoursWorked = hoursWorked + 1;
Console.WriteLine($" {firstName} has worked for {hoursWorked} hours.");
    }
    
public void stopWorking()
{
   Console.WriteLine($"{firstName} will stop working now.");
    isWorking = false;
    Console.WriteLine($"is {firstName} working? {isWorking}");
}

public void startWorking()
{
    Console.WriteLine($"{firstName} will start working now.");
    isWorking = true;
    Console.WriteLine($"is {firstName} working? {isWorking}");
}
public string getEmployee()
{
    string Emp = $"Firstname: {firstName}, Lastname: {lastName}, Employee ID: {employeeID}, Is Male?: {isMale}, Department: {department}";
    return Emp;

}
}