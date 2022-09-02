public class Collection
{
    //Datastructure: Stack,Queue,List,Dictionary
    public void LearnDs()
    {
        Stack<string> pile = new();
        pile.Push("Plate1");
        pile.Push("Plate2");
        pile.Push("Plate3");
        pile.Push("Plate4");

        pile.Pop();//Plate4 will be reduced because last In first Out

        Stack<Person> pile1 = new();
        Person p1 = new();
        pile1.Push(p1);

        Queue<decimal> line = new();
        line.Enqueue(34.6m);
        line.Enqueue(32.3m);
        line.Enqueue(31.4m);
        line.Enqueue(23.1m);

        line.Dequeue();//34.6 will be taken out as queue follows FIFO

        List<String> name = new();
        name.Add("Ram");
        name.Add("Shyam");
        name.Add("Hari");

        name.Remove("Ram");
        var x = name[1]; //using array to remove values, in this case Hari will be removed as Ram has already been removed & array always starts with 0

        //can also be written as:
        List<byte> ages = new() { 12, 45, 23, 34, 65 };
        var y = ages[2];//access 23

        //Dictionary:stores multiple datatype but the keys should be unique
        Dictionary<string, int> CountryPopulation = new();//string-keys which should be unique
        CountryPopulation.Add("Nepal", 234435345);
        CountryPopulation.Add("USA", 234235);
        CountryPopulation.Add("Russia", 345678);
        CountryPopulation.Add("China", 9787655);

        //to Remove
        CountryPopulation.Remove("Russia");//Key should be given

        //To print entire value, loop should be used

        foreach (var item in CountryPopulation) //item : Key & Value, any word can be used
        {
            Console.WriteLine($"{item.Key}-{item.Value}");

        }

    }
}