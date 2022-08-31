//Methods
public class Methods
{
    //1.Returns nothing and take no arguments
    public void Print()
    {
        Console.WriteLine("Hello");

    }
    //2.Returns something and takes no arguments
    public string GetAddress()
    {
        string address = "Chabahil,Kathmandu";
        return address;

    }
    //3.Returns something and take some arguments
    internal double Add(double x, double y)
    {
        var sum = x + y;
        return sum;

    }
    //to convert number to number-casting is used
    internal float Add(double x, int y, float z)
    {
        float sum = (float)x + y + z;
        return sum;
        //(float)-casting:because float could not convert double type x, casting is used
        //method overloading(Polymorhism)-when same method is used ex: Add but they should have different arguments;either number or datatype
    }

    //4.variable number of arguments
    internal double Add(params double[] numbers)
    {
        var sum = 0.0;
        foreach (var num in numbers)
        {
            sum = sum + num;

        }
        return sum;
    }
    //5.Optional Arguments
    internal string GetFullName(string firstName, string LastName, string salutation = "Ms")
    //Optional parameter "=" ex: in this case-Ms is optional parameter
    {
        string fn = $"{salutation} . {LastName}, {firstName}";
        return fn;
    }
    //6.Expression bodied members-no brackets,return code needed;"=>" is used
    internal float Add(int x, double y, float z) => x + (float)y + z;

    //7.Tuples
    public (float, float) GetSumAndProduct(float a, float b)
    {
        var product = a * b;
        var sum = a + b;
        return (product, sum);

    }
    //Classwork: Get Area & Perimeter of Circle
    internal (double, double) GetCircleDetails(double radius)
    {
        var Area = 3.14f * radius * radius;
        var Perimeter = 2 * 3.14f * radius;
        return (Area, Perimeter);
    }

    //Classwork:Write method which takes number array as parameter and returns maximum and minimum among all
    internal (short, short) GetMaxAndMin(short[] numbers)
    {
        short min = short.MaxValue, max = 0;


        foreach (var num in numbers)
        {
            if (min > num)
                min = num;
            if (max < num)
                max = num;

        }
        return(min,max);


    }
}



