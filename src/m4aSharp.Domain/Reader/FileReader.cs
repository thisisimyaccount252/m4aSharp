using System.IO;

namespace m4aSharp.Domain.Reader
{
    public class FileReader : IFileReader
    {
        public byte[] ReadFile(string filePath) => File.ReadAllBytes(filePath);
    }
}
