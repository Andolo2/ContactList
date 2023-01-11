using _01_ContactList_ConsoleApp.Interfaces;
using _01_ContactList_ConsoleApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace _01_ContactList_ConsoleApp.Services
{
    internal class Menu
    {
        private List<Contact> ContactList = new List<Contact>();
        private FileService file = new FileService();

        public string FilePath { get; set; } = null!;

        public void PopulateList()
        {
            var Items = JsonConvert.DeserializeObject<List<Contact>>(file.ReadToFile(FilePath));
            
        }

        public void MenySystem()
        {

            PopulateList();

            Console.WriteLine("Choose an option");
            Console.WriteLine("[1] Add a contact");
            Console.WriteLine("[2] Display a Contactr");
            Console.WriteLine("[3] Display All Contacts");
            Console.WriteLine("[4] Delete Contact");
            Console.WriteLine("[5] Press 5 to exit the program");

            var userInput = Console.ReadLine();

            while (true)
            {
                switch (userInput)
                {
                    case "1": AddContact();
                        break;
                    case "2": DisplayContact();
                        break;
                    case "3": DisplayAllContacts();
                        break;
                    case "4": DeleteContact();
                        break;
                    case "5": ExitProgram();
                        break;
                    default: Console.WriteLine("Wrong input, try again");
                        break;
                }
                Console.WriteLine("Choose an option");
                userInput = Console.ReadLine();
            }
        }

        private void DeleteContact()
        {

            Console.WriteLine("Enter a name to remove"); 
            var nameToRemove = Console.ReadLine();
            ContactList.RemoveAll(s => s.FirstName == nameToRemove);
            file.SaveToFile(FilePath, JsonConvert.SerializeObject(ContactList));
        }

        private void ExitProgram()
        {
            Environment.Exit(0);
        }

      

        private void DisplayAllContacts()
        {

        
            var Items = JsonConvert.DeserializeObject<List<Contact>>(file.ReadToFile(FilePath));

            foreach (var print in Items)
            {
                Console.WriteLine("FirstName: {0} \r\n Lastname: {1}\r\n ", print.FirstName, print.LastName);
            }
        }

        private void DisplayContact()

        {
          
            Console.WriteLine("Search by firstname");
           
            string searchPhrase = Console.ReadLine();

            var Items = JsonConvert.DeserializeObject<List<Contact>>(file.ReadToFile(FilePath));

            foreach (var filter in Items.Where(x => x.FirstName.Contains(searchPhrase)))
            {
                PopulateList();
                Console.WriteLine("FirstName: {0} \r\n Lastname: {1} \r\n PhoneNumber: {2} \r\n Email: {3} \r\n Adress: {4} \r\n Postalcode: {5} \r\n city: {6}", filter.FirstName, filter.LastName, filter.PhoneNumber, filter.Email, filter.Adress, filter.Adress, filter.PostalCode, filter.City);
            }






        }

        private void AddContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("Add firstName");
              contact.FirstName = Console.ReadLine();
            Console.WriteLine("Add lastname");
              contact.LastName = Console.ReadLine();
            Console.WriteLine("Add email");
              contact.Email = Console.ReadLine();
            Console.WriteLine("Add phonenumber");
              contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Add adress");
              contact.Adress = Console.ReadLine();
            Console.WriteLine("Add postalcode");
              contact.PostalCode = Console.ReadLine();
            Console.WriteLine("Add city");
              contact.City = Console.ReadLine();

             ContactList.Add(contact);

            file.SaveToFile(FilePath, JsonConvert.SerializeObject(ContactList));

            MenySystem();
        }
    }
}
