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
            // Quit program.
            return 0;
        }
    }

    private static void Prompt()
    {
        Console.Write(string.Join("\n",
            "1 | Search", "2 | Edit", "3 | Load", "4 | Save", "5 | Create", "6 | Destroy", null)
        );
    }

    private static void Execute(uint action)
    {
        switch (action)
        {
            case 1:
                Console.WriteLine("Search keyword(s): ");
		string? keywords = Console.ReadLine();
		results = _database.search(keywords);
                break;

            case 2:
                Console.WriteLine("Domain: ");
		string? domain = Console.ReadLine();
		Console.WriteLine("New password: ");
 		string? password = Console.ReadLine();
		_database.edit(domain, password);
                break;

            case 3:
                Consolle.WriteLine("Loading database...");
                break;

            case 4:
                Console.WriteLine("Saving database...");
                break;

            case 5:
                Console.WriteLine("Creating database...");
                Console.Write("Pathname: ");
                string? path = Console.ReadLine();
                _database = new(path);
                break;

            case 6:
                Console.WriteLine("Destroying database...");
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
