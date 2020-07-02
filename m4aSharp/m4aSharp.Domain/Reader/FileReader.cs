using System.IO;

namespace m4aSharp.Domain.Reader
{
    // TODO: Once we write the file parser, let's use these as sources:
    // https://www.file-recovery.com/m4a-signature-format.htm
    // https://ahyattdev.github.io/blog/2018/02/17/m4a-metadata-structure.html
    public class FileReader : IFileReader
    {
        public byte[] ReadFile(string filePath) => File.ReadAllBytes(filePath);
    }
}
