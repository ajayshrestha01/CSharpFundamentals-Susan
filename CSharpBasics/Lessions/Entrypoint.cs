using Inheritance;
class EntryPoint
{
    public static void Main()
    {
        // Branching b = new();
        // b.LearnBranching();

        // Methods c = new();
        // var d = c.Add(34, 23);
        // var d1 = c.Add(23, 34, 54, 34, 56);
        // var d2 = c.Add(32.8, 45, 67);
        // var d3 = c.Add(32, 45.67, 12);

        // var fn = c.GetFullName("Susan", "Sharma", "Ms");
        // Console.WriteLine(fn);

        // var (p,s) = c.GetSumAndProduct(33.6f,56.2f);
        // Console.WriteLine(p);

        // var (A, P) = c.GetCircleDetails(3.4);
        // Console.WriteLine($"Area: {A}");
        // Console.WriteLine($"Perimeter:{P}");

        // short[] numbers = { 2, 4, 7, 9, 4, 10, 23 };
        // var (Min, Max) = c.GetMaxAndMin(numbers);
        // Console.WriteLine($"Minimum Value: {Min}");
        // Console.WriteLine($"Maximum Value: {Max}");

        Vehicle1 v1 = new();
        v1.Mileage = 12.3f;
        v1.VNumber = "Ba 2 Cha 230Pa";
        v1.load = 10.5;
        v1.Print();

        Car C1 = new();
        C1.PrintCarFeatures();

        IEngine t1 = new Truck();
        




    }
}

