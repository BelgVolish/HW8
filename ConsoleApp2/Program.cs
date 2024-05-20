namespace ConsoleApp2;

static class Program
{
    public static void Main()
    {
        DoApp();
    }

    public static void DoApp()
    {
        while (true)
        {
            Console.WriteLine("Выберите действие");
            if (!Enum.TryParse(Console.ReadLine(), true, out TaskType taskType))
            {
                Console.WriteLine("Не удалось распознать команду");
                DoApp();
            }
            else
            {
                switch (taskType)
                {
                    case TaskType.RandomsNums:
                        RandomNums.RandomNumsOperation();
                        break;
                    case TaskType.PhoneBook:
                        PhoneBook.DoPhoneBook();
                        break;
                    case TaskType.RepeatsCheck:
                        RepeatsCheck.VoidAddToHashSet();
                        break;
                    case TaskType.NoteBook:
                        NoteBook.DoNeteBook();
                        break;
                    case TaskType.Exit:
                        Environment.Exit(0);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}

internal enum TaskType
{
    RandomsNums,
    PhoneBook,
    RepeatsCheck,
    NoteBook,
    Exit
}

