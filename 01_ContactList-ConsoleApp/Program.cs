using _01_ContactList_ConsoleApp.Services;

namespace _01_ContactList_ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            Menu runApp = new Menu();
        

            runApp.FilePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";

            while (true)
            {

                runApp.MenySystem();
            }
          

        }
    }
}