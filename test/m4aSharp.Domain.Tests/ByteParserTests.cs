using System;
using Xunit;
using m4aSharp.Domain.Model;
using m4aSharp.Domain.Reader;

namespace m4aSharp.Domain.Tests
{
    public class ByteParserTests
    {
        [Fact]
        public void ShouldParseType()
        {
            var byteParser = new ByteParser();

            var sut = byteParser.ParseBytes(new SampleFile().Bytes);

            Assert.Equal(FileType.M4A, sut.FileType);
        }

        [Fact]
        public void ShouldThrowExceptionIfFileTypeIsInvalid()
        {
            var byteArray = new byte[] {0,0,0,0,99,32,1,34};
            var byteParser = new ByteParser();

            Assert.Throws<Exception>(() => byteParser.ParseBytes(byteArray));
        }
    }
}