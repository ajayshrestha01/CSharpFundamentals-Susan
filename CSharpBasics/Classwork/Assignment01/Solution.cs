public class Solution
{
    
public void CheckEvenOdd()
{
    var number = 23;
    if (number%2 == 0)
    {
        Console.WriteLine("Even");

    }
    else{
        Console.WriteLine("Odd");

    }


{

}
}
public void LearnSwitch()
{
var DayOfWeek = DateTime.Today.DayOfWeek;
switch(DayOfWeek)
{
    case DayOfWeek.Sunday: Console.WriteLine("Today is SUnday");
    break;
    case DayOfWeek.Monday: Console.WriteLine("Today is Monday");
    break;
    case DayOfWeek.Tuesday: Console.WriteLine("Today is Tuesday");
    break;
    case DayOfWeek.Wednesday: Console.WriteLine("Today is Wednesday");
    break;
    case DayOfWeek.Thursday: Console.WriteLine("Today is Thursday");
    break;
    case DayOfWeek.Friday: Console.WriteLine("Today is Friday");
    break;
    case DayOfWeek.Saturday: Console.WriteLine("Today is Saturday");
    break;
    default:Console.WriteLine("unknown day");
    break;
    
}

}

}




