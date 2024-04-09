using Example3_Printer.OriginalCode;

internal class Program
{
    static void Main(string[] args)
    {
        // Original code
        Console.WriteLine("--- Not wrapped code ---");
        new Application().Run();

        // Wrapper code
        Console.WriteLine("--- Wrapped code ---");
        new Example3_Printer.WrapperCode.Application().Run();
    }
}