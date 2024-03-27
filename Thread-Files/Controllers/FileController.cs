using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thread_Files.Extensions;
using Thread_Files.Services;
using Thread_Files.Services.Interfaces;

namespace Thread_Files.Controllers
{
    internal class FileController
    {
        private readonly IFileService _fileService;

        public FileController()
        {
            _fileService=new FileService();
        }
        public async Task ReadDataAsync()
        {
            string result = await _fileService.ReadFromFileAsync("C:\\Users\\Əsgərxan\\Desktop\\Thread-Files\\file6.txt");
            Console.WriteLine(result);
        }


       // "C:\\Users\\Əsgərxan\\Desktop\\Thread-Files"
        public async Task CreatedFileWithContentAsync()
        {
            await Console.Out.WriteLineAsync("Add path:");
            string path =Console.ReadLine();

            await Console.Out.WriteLineAsync("Add file name:");
            string fileName = Console.ReadLine();

            await Console.Out.WriteLineAsync("Add your text:");

            string text=Console.ReadLine();

            string resultPath = path.GenerateFullPath(fileName);
            await _fileService.WriteToNewFileAsync(resultPath,text);
        }
        public async Task DeleteAsync()
        {
            await _fileService.DeleteAsync("C:\\Users\\Əsgərxan\\Desktop\\Thread-Files\\file7.txt");
        }
    }
}
