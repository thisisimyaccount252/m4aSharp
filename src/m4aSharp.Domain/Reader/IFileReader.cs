namespace m4aSharp.Domain.Reader
{
    public interface IFileReader
    {
        byte[] ReadFile(string filePath);
    }
}
