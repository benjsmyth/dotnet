Console.WriteLine("PassMan | Password manager");
Manager.Work();

abstract class Manager
{
    public static void Work()
    {
        uint action;
        while ( (action = Prompt() ) > 0)
        {
            Execute(action);
        }
        Console.WriteLine("Quitting");
    }
    private static uint Prompt()
    {
        Console.WriteLine("""
            1: Search
            2: Edit
            3: Load
            4: Save
            5: Reset
            Q: Quit
        """); return Select();
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
            Console.Write("IOException. ");
            return 0;
        }
        catch (FormatException)
        {
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
