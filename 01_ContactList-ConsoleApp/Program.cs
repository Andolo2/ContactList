using _01_ContactList_ConsoleApp.Services;

namespace _01_ContactList_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Menu runApp = new Menu();
            runApp.MenySystem();
        }
    }
}