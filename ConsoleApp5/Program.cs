internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        if (name == String.Empty)
            name = "No name";
        Console.WriteLine("Welcome {0} to dotnet world", name);
    }
}