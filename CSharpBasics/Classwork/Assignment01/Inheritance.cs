public class Shapes
{
    public float length {get; set;}
    public float breadth {get; set;}
    public float PrintArea(float length, float breadth)
    {
        var Area = length * breadth;
        return Area;
    }
}