using Example1_FileStorage.OriginalCode;

internal class Program
{
    static void Main(string[] args)
    {
        // Original Code
        Console.WriteLine("--- Not wrapped code ---");
        new Application().Run();
        Console.WriteLine();

        // Wrapper Code
        Console.WriteLine("--- Wrapped code using InMemory File Storage ---");
        new Example1_FileStorage.WrapperCode.Application(new Example1_FileStorage.WrapperCode.Implementations.InMemoryFileStorage()).Run();
        Console.WriteLine();

        Console.WriteLine("--- Wrapped code using File Storage ---");
        new Example1_FileStorage.WrapperCode.Application(new Example1_FileStorage.WrapperCode.Implementations.FileStorage()).Run();
        Console.WriteLine();
    }
}