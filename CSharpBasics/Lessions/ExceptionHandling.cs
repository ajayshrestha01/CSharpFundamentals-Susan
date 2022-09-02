public class ExceptionHandling
{
    public void CreateDictionary()
    {
        //to handle logical error; if we intentionally want to print Russia twice: try & catch

        try
        {
            Dictionary<string, int> CountryPopulation = new();
            CountryPopulation.Add("Nepal", 234435345);
            CountryPopulation.Add("USA", 234235);
            CountryPopulation.Add("Russia", 345678);
            CountryPopulation.Add("China", 9787655);
            //CountryPopulation.Add("Russia", 345678);

            CountryPopulation.Remove("Russia");

            foreach (var item in CountryPopulation)
            {
                Console.WriteLine($"{item.Key}-{item.Value}");

            }
            int f = 34;
            if (f<50)
            {
                throw new Exception("f can't be less than 50");//custom handling of exception, should be within the try code block
            }
            else
            {

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message ?? ex.InnerException.Message); //Null Coalescing operator, if the 1st message is null it goes to the inner message
        }
        finally //even if there is error or not, finally block will be executed
        {
            Console.WriteLine("Code block executed, Thank You");

        }
    }
}