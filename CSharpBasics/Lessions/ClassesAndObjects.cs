class Person
{
    internal string firstName;
    internal string lastName;
    internal byte age;
   internal bool isFemale;

   internal void SpeakLanguage()
    {
Console.WriteLine(firstName +" speaks english.");

    }
}


class Test
{
  internal  void Do()
    {
        //create object/ Instantiate / Create Instance
        Person susan = new Person();

        //set susan's (object) data

        susan.firstName = "Susan";
        susan.lastName = "Sharma";
        susan.age = 25;
        susan.isFemale = true;

        //call object method
        susan.SpeakLanguage();
    }
    
}