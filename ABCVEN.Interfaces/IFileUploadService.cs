using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCVEN.Interfaces
{
    public interface IFileUploadService
    {
        string[,] ReadFile(string filePath);
    }
}
