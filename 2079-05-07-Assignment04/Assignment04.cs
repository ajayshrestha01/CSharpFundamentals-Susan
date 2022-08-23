//Assignment-1-Print Odd numbers less than 1000
Console.WriteLine("Odd numbers Less than 1000:");

for (int g = 1; g < 1000; g++)
{
    if (g % 2 != 0 && g != 999)
    {
        Console.Write(g + ",");
    }
    if (g == 999)
    {
        Console.Write(g + "\n");

    }
}


//Assignment-2-Print multiplication table for 5
Console.WriteLine("Multiplication Table for 5:");


for (int t = 5, b = 1; b <= 10; b++)
{
    Console.WriteLine(t + "x" + b + "=" + t * b);

}
