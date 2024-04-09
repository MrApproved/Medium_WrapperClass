using Example1_FileStorage.WrapperCode.Interfaces;

namespace Example1_FileStorage.WrapperCode
{
    public class Application
    {
        private readonly IFileStorage _fileStorage;

        public Application(IFileStorage fileStorage)
        {
            _fileStorage = fileStorage;
        }

        public void Run()
        {
            var fileName = $"{Guid.NewGuid()}.txt";

            Console.Write("Provide firstname:");
            var firstName = Console.ReadLine();
            Console.Write("Provide lastname:");
            var surname = Console.ReadLine();

            _fileStorage.SaveFile(fileName, $"Hello {firstName} {surname}!");
            Console.Write(_fileStorage.LoadFile(fileName));
            _fileStorage.DeleteFile(fileName);
        }
    }
}