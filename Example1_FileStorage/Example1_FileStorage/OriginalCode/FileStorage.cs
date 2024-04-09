namespace Example1_FileStorage.OriginalCode
{
    public class FileStorage
    {
        public void DeleteFile(string fileName)
            => File.Delete(fileName);

        public string LoadFile(string fileName)
            => File.ReadAllText(fileName);

        public void SaveFile(string fileName, string fileContents)
            => File.WriteAllText(fileName, fileContents);
    }
}