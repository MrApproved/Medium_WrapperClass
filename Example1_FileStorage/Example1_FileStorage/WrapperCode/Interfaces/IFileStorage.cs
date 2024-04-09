namespace Example1_FileStorage.WrapperCode.Interfaces
{
    public interface IFileStorage
    {
        void SaveFile(string fileName, string fileContents);
        string LoadFile(string fileName);
        void DeleteFile(string fileName);
    }
}