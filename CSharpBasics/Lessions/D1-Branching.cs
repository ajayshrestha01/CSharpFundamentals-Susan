public class Branching
{
    public void LearnBranching()
    {
        //Example1
        var A = Console.ReadLine();
        if (A == "Y")
        {
            Console.WriteLine("You said Yes");
        }

        else
        {
            Console.WriteLine("You said No");
        }
        //Example 2
        var marks = 30;
        if (marks < 40)
        {
            Console.WriteLine("You got E");
        }
        else if (marks < 50)
        {
            Console.WriteLine("You got D");
        }
        else if (marks < 60)
        {
            Console.WriteLine("You got C");
        }
        else if (marks < 70)
        {
            Console.WriteLine("You got B");
        }
        else
        {
            Console.WriteLine("You got A");

        }
    }
    
   
    
}

//Classwork
