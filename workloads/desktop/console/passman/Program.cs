Console.WriteLine("Passman | Password manager");

sealed class Database
{
    public interface IDatabase
    {
    
    }

    public static Password? Find(string password)
    {
        return null;
    }
}

abstract class Generator : Database.IDatabase
{
    private readonly Password? password;
    public static Password Generate()
    {
        string password = "generatedPassword";
        return new Password(password);
    }
}

sealed class Password(string password)
{
    private readonly string? value = password;
}
