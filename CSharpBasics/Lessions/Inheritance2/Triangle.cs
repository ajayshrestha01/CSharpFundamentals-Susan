namespace Shapes;
public class Triangle : IShape
{
    double a, b, c;
    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;

    }
    public double GetArea()
    {
        var s = (a + b + c) / 2;
        var area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        return area;
    }
    public double GetPerimeter()
    {
        var Perimeter = (a + b + c);
        return Perimeter;

    }

}