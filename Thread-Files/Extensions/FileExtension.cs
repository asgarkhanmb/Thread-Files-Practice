using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_Files.Extensions
{
    internal static class FileExtension
    {
        public static string GenerateFullPath(this string path,string fileName)
        {
            return $"{path}\\{fileName}";
        }
    }
}
