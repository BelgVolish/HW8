namespace ConsoleApp2;

public static class RepeatsCheck
{
    private static readonly HashSet<int> Ints = new HashSet<int>();

    public static void VoidAddToHashSet()
    {
        Console.WriteLine("Введите число");
        if (!int.TryParse(Console.ReadLine(), out int num))
        {
            Console.WriteLine("Введено не число");
            Program.DoApp();
        }
        else
        {
            Console.WriteLine(Ints.Add(num) ? "Число успешно добавлено" : "Такое число уже есть");
        }
    }
}