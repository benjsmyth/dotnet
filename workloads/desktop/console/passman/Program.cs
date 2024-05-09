Console.WriteLine("PassMan | Password manager");
Manager.Run();

abstract class Manager
{
    public static void Run()
    {
        uint action;
        while ( (action = Prompt() ) > 0)
        {
            Execute(action);
        }
    }
    public static uint Prompt()
    {
        Console.WriteLine("\t1: Search");
        Console.WriteLine("\t2: Edit");
        Console.WriteLine("\t3: Load");
        Console.WriteLine("\t4: Save");
        Console.WriteLine("\t5: Reset");
        Console.WriteLine("\tQ: Quit");
        return Select();
    }
    private static uint Select()
    {
        Console.Write("Select: ");
        try
        {
            string? value = Console.ReadLine();
            return Convert.ToUInt16(value);
        }
        catch (IOException)
        {
            Console.WriteLine("IOException. Quitting");
            return 0;
        }
        catch (FormatException)
        {
            Console.WriteLine("Quitting");
            return 0;
        }
    }
    private static void Execute(uint action)
    {
        Console.WriteLine($"Executing {action}");
    }
}

// sealed class Database : ISortable
// {
//     private readonly string _Path;
//     private readonly Stream _Stream;
//     private readonly BinaryWriter _Writer;

//     public Database(string path)
//     {
//         _Path = @path;
//         // Check for nullability!
        
//         _Stream = File.Open(_Path, FileMode.OpenOrCreate);
//         // Remember to close!

//         _Writer = new BinaryWriter(_Stream, Encoding.UTF8);
//         // Remember to close!
//     }
//     public static void Sort()
//     {
//         return;
//     }
// }
// abstract class Generator : ISortable
// {
//     public static readonly Password[] passwords = [];
//     public static Password Generate()
//     {
//         return new("", []);
//     }
//     public static void Sort()
//     {
//         return;
//     }
// }
// interface ISortable
// {
//     abstract static void Sort();
// }
// record Password(string Value, string[] Keys);
