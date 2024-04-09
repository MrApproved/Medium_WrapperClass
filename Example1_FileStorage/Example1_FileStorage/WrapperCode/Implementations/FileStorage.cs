using Example1_FileStorage.WrapperCode.Interfaces;

namespace Example1_FileStorage.WrapperCode.Implementations
{
    public class FileStorage : IFileStorage
    {
        public void DeleteFile(string fileName)
            => File.Delete(fileName);

        public string LoadFile(string fileName)
            => File.ReadAllText(fileName);

        public void SaveFile(string fileName, string fileContents)
            => File.WriteAllText(fileName, fileContents);
    }
}