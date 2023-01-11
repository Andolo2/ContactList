using _01_ContactList_ConsoleApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ContactList_ConsoleApp.Services
{
    internal class FileService
    {

        public void SaveToFile(string FilePath, string content)
        {
            using var sw = new StreamWriter(FilePath);
            sw.WriteLine(content);

           
        }

        public string ReadToFile(string FilePath)
        {
            using var sr = new StreamReader(FilePath);
            return sr.ReadToEnd();
        }
    }
}

