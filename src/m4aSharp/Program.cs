using System;
using System.Linq;
using m4aSharp.Domain.Reader;

namespace m4aSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // I used this for gettign a byte array that I could cpy and paste into automated tests
        private static string GetFileAsCopyPasteByteArray(string file)
        {
            var sampleBytes = new FileReader().ReadFile(file);

            // Convert the bytes to integers so the bytes are rendered as integers. Makes each value more condensed and easier to read.
            var bytesAsInts = sampleBytes.Select(b => (int)b).ToArray();

            // Converts to json, which is a very straightforward copy-paste format
            return System.Text.Json.JsonSerializer.Serialize(bytesAsInts);
        }
    }
}
