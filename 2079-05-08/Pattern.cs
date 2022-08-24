public class PyramidPatterns
{
    public void MakeFisrtPattern()
    {
        for (int i = 1; i <= 6; i++)
        {

            for (int j = 0; j < i; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();

        }
    }

    public void MakeSecondPattern()
    {
        for (int i = 1; i <= 6; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();

        }
    }

}