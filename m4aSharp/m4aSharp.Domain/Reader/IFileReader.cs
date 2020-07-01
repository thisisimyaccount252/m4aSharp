using System;
using System.Collections.Generic;
using System.Text;

namespace m4aSharp.Domain.Reader
{
    public interface IFileReader
    {
        byte[] ReadAllFiles();
    }
}
