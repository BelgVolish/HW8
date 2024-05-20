namespace ConsoleApp2;

public static class PhoneBook
{
    private static readonly Dictionary<string, List<int>> PhoneBookDictionary = new Dictionary<string, List<int>>();
    public static void DoPhoneBook()
    {
        Console.WriteLine("Выберите действие с телефонной книгой");
        if (!Enum.TryParse(Console.ReadLine(), true, out PhoneBookOperations phoneBookOperations))
        {
            Console.WriteLine("Не удалось распознать команду");
            DoPhoneBook();
        }
        else
        {
            switch (phoneBookOperations)
            {
                case PhoneBookOperations.AddUser:
                    AddUser();
                    break;
                case PhoneBookOperations.FindUser:
                    FindUserByPhone();
                    break;
                case PhoneBookOperations.Exit:
                    Program.DoApp();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

    private static void AddUser()
    {
        Console.WriteLine("Введите ФИО контакта");
        string? name = Console.ReadLine()?.ToLower();
        List<int> numbers = new List<int>();
        Console.WriteLine("Введите номера телефонов исключительно цифрами");
        string n = "Я плейсхолдер";
        while (!string.IsNullOrEmpty(n))
        {
            n = Console.ReadLine()!;
            if (int.TryParse(n, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Введён некорректный номер");
            }
        }
        
        PhoneBookDictionary.Add(name!, numbers);
        DoPhoneBook();
    }

    private static void FindUserByPhone()
    {
        Console.WriteLine("Введите номер телефона исключительно цифрами");
        string name = string.Empty;
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            foreach (var var in PhoneBookDictionary.Where(var => var.Value.Contains(number)))
            {
                name = var.Key;
            }

            Console.WriteLine(string.IsNullOrEmpty(name)
                ? "Такой пользователь не найден"
                : $"Данный номер принадлежит {name}");
        }
        else
        {
            Console.WriteLine("Введён некорректный номер");
        }
    }
}

internal enum PhoneBookOperations
{
    AddUser,
    FindUser,
    Exit
}