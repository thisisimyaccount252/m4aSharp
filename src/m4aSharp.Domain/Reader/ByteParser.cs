using System;
using System.Linq;
using m4aSharp.Domain.Model;

namespace m4aSharp.Domain.Reader
{
    // https://www.file-recovery.com/m4a-signature-format.htm
    // https://ahyattdev.github.io/blog/2018/02/17/m4a-metadata-structure.html
    public class ByteParser
    {
        public M4aTag ParseBytes(byte[] bytes)
        {
            var result = new M4aTag();
            var typeBytes = bytes.Skip(8).Take(3).ToArray();

            var fileTypeString = System.Text.Encoding.Default.GetString(typeBytes);
            if (Enum.TryParse(fileTypeString, out FileType fileType))
            {
                result.FileType = fileType;
            }
            else
            {
                throw new Exception($"Invalid File Type '{fileTypeString}'.");
            }

            return result;
        }
    }
}