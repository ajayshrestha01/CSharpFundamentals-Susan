//Vehicle1 Parent Class- Car class can reuse the predefined properties of Vehicle1
//A <-B - single inheritance

namespace Inheritance; //namespace is a container that stores similar classes;allows reuse of same class in different projects
class Car: Vehicle1 
{
public string Model { get; set; }
public void PrintCarFeatures()
{
    Console.WriteLine("\nFeatures:\n\t- Airbags\n\t-4x4 wheel drive\n\t-Hybrid");
}
}
