using Example1_FileStorage.WrapperCode.Interfaces;

namespace Example1_FileStorage.WrapperCode.Implementations
{
    public class InMemoryFileStorage : IFileStorage
    {
        private IDictionary<string, string> Files { get; set; }

        public InMemoryFileStorage()
        {
            Files = new Dictionary<string, string>();
        }

        public void DeleteFile(string fileName)
        {
            if(Files.ContainsKey(fileName))
                Files.Remove(fileName);
        }

        public string LoadFile(string fileName)
        {
            if (Files.ContainsKey(fileName))
                return Files[fileName];
            return string.Empty;
        }

        public void SaveFile(string fileName, string fileContents)
            => Files[fileName] = fileContents;
    }
}