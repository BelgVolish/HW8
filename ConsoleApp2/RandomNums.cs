namespace ConsoleApp2;

public static class RandomNums
{
    public static void RandomNumsOperation()
    {
        List<int> ints = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            Random random = new Random();
            int r = random.Next(0, 100);
            ints.Add(r);
            Console.WriteLine(r);
        }
        
        Console.WriteLine("Проводим операции над числами");

        foreach (var var in new List<int>(ints).Where(var => var is > 25 and < 50))
        {
            ints.Remove(var);
            Console.WriteLine(var);
        }
        
        Program.DoApp();
    }
}