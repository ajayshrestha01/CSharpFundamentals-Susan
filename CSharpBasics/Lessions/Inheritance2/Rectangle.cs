namespace Shapes;
public class Rectangle : IShape
{
    //Default parameterless constructor
    // public Rectangle()
    // {

    // }

    public Rectangle(double l, double b) //parametarized Constructor
    {
        length = l;
        breadth = b;
    }
    public double length, breadth;

    public double GetArea() => length * breadth;

    public double GetPerimeter() => 2 * (length + breadth);


}