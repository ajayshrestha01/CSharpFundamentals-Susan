public class Array
{
    public void LearnArrayID()
    {
        byte age = 23;

        byte[] personAges = new byte[1000];

        //Array Indexing
        personAges[0] = 25;
        personAges[1] = 30;
        personAges[2] = 40;
        personAges[3] = 45;

        var x = personAges[2];

void LearnJaggedArray()
{
    decimal[][]table = new decimal[3][];
    table[0] = new decimal[]{34.56m, 45.22m, 645.67m };
    table[1] = new decimal[]{45.22m, 645.67m };
    table[2] = new decimal[]{34.56m, 645.67m };

//to get 3rd element of 3rd row
    var x = table[2][2];



}

    }


}