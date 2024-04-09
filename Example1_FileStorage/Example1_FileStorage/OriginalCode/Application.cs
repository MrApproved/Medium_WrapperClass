namespace Example1_FileStorage.OriginalCode
{
    public class Application
    {
        public void Run()
        {
            var fileStorage = new FileStorage();
            var fileName = $"{Guid.NewGuid()}.txt";

            Console.Write("Provide firstname:");
            var firstName = Console.ReadLine();
            Console.Write("Provide lastname:");
            var surname = Console.ReadLine();

            fileStorage.SaveFile(fileName, $"Hello {firstName} {surname}!");
            Console.Write(fileStorage.LoadFile(fileName));
            fileStorage.DeleteFile(fileName);
        }
    }
}