Manager.Work();

static class Manager
{
    private static Database? _database;

    public static void Work()
    {
        uint action;
        while ( (action = Select() ) > 0)
        {
            Execute(action);
        }
        Console.WriteLine("Quitting");
    }

    private static uint Select()
    {
        Prompt();
        try
        {
            string? value = Console.ReadLine();
            return Convert.ToUInt16(value);
        }
        catch (FormatException)
        {
            // Quit
            return 0;
        }
    }

    private static void Prompt()
    {
        Console.Write(string.Join(" | ",
            null, "Search", "Edit", "Load", "Save", "Create", "Destroy", "Quit", null)
        );
    }

    private static void Execute(uint action)
    {
        switch (action)
        {
            case 5:
                Console.Write("Pathname: ");
                string? path = Console.ReadLine();
                _database = new(path);
                break;

            default:
                break;
        }
    }
}

sealed class Database : ISortable
{
    private readonly string _Path;
    // private readonly Stream _Stream;
    // private readonly BinaryWriter _Writer;

    public Database(string? path)
    {
        _Path = path!;
        Console.WriteLine($"Created database at {_Path}");
        // _Stream = File.Open(_Path, FileMode.OpenOrCreate);
        // Remember to close!

        // _Writer = new BinaryWriter(_Stream, System.Text.Encoding.UTF8);
        // Remember to close!
    }

    public static void Sort()
    {
        return;
    }
}

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

interface ISortable
{
    abstract static void Sort();
}

// record Password(string Value, string[] Keys);
