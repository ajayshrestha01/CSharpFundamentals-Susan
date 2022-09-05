//Parallel Programming: Thread(Multithreading)
//Asynchronous Programming - ex:tea making process

public class ParallelAndAsync
{
    public void Do()
    {
       

        Console.WriteLine("Doing it in sequence");
        for (int i = 1; i< 5; i++)
        {
            DoTask(i);
        }
      
    }

    public void DoParallel()
    {
        Console.WriteLine("Doing it in parallel");
        Parallel.For(1, 5,(int i)=> {  //providing range=1 to 5
            DoTask(i);
        });
    }
    public void DoTask(int n)
    {
        Console.WriteLine($"Started task for {n}");
        Thread.Sleep(1000); //paused method for 1000 ms
        Console.WriteLine($"Completed task for {n}");
    }
}