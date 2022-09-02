public class Generics
{
    //Generics <>: can take any datatype, datatype to be declared in entrypoint
    //class can also be generic: when you instantiate use <> ex: Generic <int> g = new();
    public void Print<T>(T info)
    {
        Console.WriteLine(info);
    }
}
// Generics g=new();
// g.Print<short>(56);
// g.Print<decimal>(23.2m);//even if not declared compiler can infer the datatype if proper parameter is given
// g.Print<float>(24.5f);
// g.Print<String>("23");