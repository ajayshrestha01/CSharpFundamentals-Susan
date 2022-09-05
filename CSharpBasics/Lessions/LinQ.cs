//Language Integrated Querrym(LINQ)
public class Linq
{
    int[] numbers = { 2, 3, 45, 12, 23, 34, 45, 78, 43, 54 };
    string[] names = { "Susan", "Ajay", "Bisakha", "Aditya", "Bishnu", "avash", "binita" };

    List<Person> people = new()
{
    new Person {firstName = "D", lastName="A", age=12},
    new Person {firstName = "A", lastName="B", age=24},
    new Person {firstName = "B", lastName="C", age=34},
    new Person {firstName = "C", lastName="D", age=56},

};

    public void LearnLinq()
    {
        //1.Get all odd numbers from array "numbers"
        //imperative method
        List<int> oddnumbers = new();
        foreach (int num in numbers)
        {
            if (num % 2 != 0)
            {
                oddnumbers.Add(num);

            }
        }
        //using Linq
        //Filters-Where : filters desired results from given collection
        var oddNums = numbers.Where(num => num % 2 != 0);

        //1.1 Get all numbers which are multiple of 3 & 5
        var multiple = numbers.Where(num => num % 3 == 0 && num % 5 == 0);
        Print(multiple);

        //2.Get squares of all the numbers in array "numbers"
        //Projections 
        var squares = numbers.Select(num => num * num);

        //2.1 Get square root of each element on "numbers"
        var squareroot = numbers.Select(num => Math.Sqrt(num));
        Print(squareroot);

        //1.2 Fetch all names which starts from letter A or B
        var NameFromAorB = names.Where(Name => Name.ToUpper().StartsWith("A") || Name.ToUpper().StartsWith("B"));
        Print(NameFromAorB);

        //3.skip and Take
        //Get first 5 names from "Names"
        var FirstFive = names.Take(5);

        //3.1 ignore first 2 & get later 3 from "Names"
        var ignore2Get3 = names.Skip(2).Take(3);
        Print(ignore2Get3);

        //1.3 Get all person older than 20 years
        var p = people.Where(x => x.age > 20);
        Print(p);

        var a = numbers.Min();
        var a1 = numbers.Max();
        var a2 = numbers.Average();
        var numbers1 = numbers.OrderBy(x => x);


    }
    private void Print<T>(IEnumerable<T> nums)
    {
        Console.WriteLine();
        foreach (var item in nums)
        {
            Console.Write($"{item} ");

        }

    }
}
