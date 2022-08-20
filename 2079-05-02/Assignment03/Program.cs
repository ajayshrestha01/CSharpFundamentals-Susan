public class Program{
    public static void Main(){
        var Susan = new Employee();
Susan.firstName = "Susan";
Susan.lastName = "Sharma";
Susan.employeeID = 20;
Susan.isMale = false;
Susan.department = "Finance";

Susan.startWorking();


Susan.work();


Susan.work();

Susan.stopWorking();
Console.WriteLine($"Employee Information{Susan.getEmployee()}");
    }

}

