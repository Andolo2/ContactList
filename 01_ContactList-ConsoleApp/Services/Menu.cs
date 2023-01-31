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
using System.IO.MemoryMappedFiles;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;

namespace _01_ContactList_ConsoleApp.Services
{
    public class Menu : Contact
    {
        public List<Contact> ContactList = new List<Contact>(); // Contact list
        private FileService file = new FileService(); // Instanciate fileservice

        public string FilePath { get; set; } = null!; // Get/Set the filepath

        public void MenySystem() // Menu system with a while loop and a switch case to enter the menu details.
        { 

            Console.WriteLine("** Choose an option ** \n");
            Console.WriteLine("[1] Add a contact");
            Console.WriteLine("[2] Search - Contact details");
            Console.WriteLine("[3] Display all Contacts");
            Console.WriteLine("[4] Delete Contact");
            Console.WriteLine("[5] Press 5 to Exit the program");

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

        private void DeleteContact() // Try/catch statement where the user can search by firstname and remove a contact. (Added a simulated "buffer" just for fun)
        {
            try 
            {
                Console.WriteLine("Enter a name to remove");
                string nameToRemove = Console.ReadLine();
                ContactList.RemoveAll(s => s.FirstName.Contains(nameToRemove));
                file.SaveToFile(FilePath, JsonConvert.SerializeObject(ContactList, Formatting.Indented));

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("contact deleted.");
            }
            catch
            {
                Console.WriteLine("Wrong input, try again");
            }
        }

        private void ExitProgram() // If the user want´s to terminate the app by themselfs.
        {
            Environment.Exit(0);
        }

        private void DisplayAllContacts() // try/catch statement where the user can display all contacts. If the list is emtpy the user will be informed. 
        {                                 // Prints out the first, lastname and Email.
            Console.Clear();

            var Items = JsonConvert.DeserializeObject<List<Contact>>(file.ReadToFile(FilePath));

            try
            {
               if(Items.Count == 0)
                {
                    Console.WriteLine("No contacts found. ");
                }
                else
                {
                    foreach (var print in Items)
                    {
                        Console.WriteLine("FirstName: {0} \r\n Lastname: {1}\r\n Email: {1}\r\n ", print.FirstName, print.LastName, print.Email);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Not found, try again");
            }
        }

        private void DisplayContact() // Let´s the user search by firstname, if the contact can be found. All details will be deisplayed.

        {
            Console.WriteLine("Search by firstname");
           
            string searchPhrase = Console.ReadLine();

            var Items = JsonConvert.DeserializeObject<List<Contact>>(file.ReadToFile(FilePath));

            foreach (var filter in Items.Where(x => x.FirstName.Contains(searchPhrase)))
            {
                if ( filter == null || searchPhrase == string.Empty) 
                {
                    Console.WriteLine("No contacts found.");
                }
              
                else
                {                 
                    Console.WriteLine("FirstName: {0} \r\n Lastname: {1} \r\n PhoneNumber: {2} \r\n Email: {3} \r\n Adress: {4} \r\n Postalcode: {5} \r\n city: {6}", filter.FirstName, filter.LastName, filter.PhoneNumber, filter.Email, filter.Adress, filter.Adress, filter.PostalCode, filter.City);
                }
            }
        }

        private void AddContact() // Method that let´s the user add a contact, made a very simple verification to make sure no filed is empty. Save´s to list and displays the main menu again.
        {
           
            Contact contact = new Contact();
            Console.WriteLine("Add firstName");
           
            contact.FirstName = Console.ReadLine();
            while (string.IsNullOrEmpty(contact.FirstName))
            {
                Console.WriteLine("Please add a firstname");
                contact.FirstName = Console.ReadLine(); 
            }
           
            Console.WriteLine("Add lastname");
              contact.LastName = Console.ReadLine();
            while (string.IsNullOrEmpty(contact.LastName))
            {
                Console.WriteLine("Please add a LastName");
                contact.LastName = Console.ReadLine();
            }

            Console.WriteLine("Add email"); // Bad validation, need to remake conditons..
           
            contact.Email = Console.ReadLine().ToLower();
            while (!contact.Email.Contains("@"))
            {
                Console.WriteLine("Please add a valid Email");
                contact.Email = Console.ReadLine();
            }

            Console.WriteLine("Add phonenumber");
              contact.PhoneNumber = Console.ReadLine();
            while (string.IsNullOrEmpty(contact.PhoneNumber))
            {
                Console.WriteLine("Please add a PhoneNumber");
                contact.PhoneNumber = Console.ReadLine();
            }

            Console.WriteLine("Add adress");
              contact.Adress = Console.ReadLine();

            while (string.IsNullOrEmpty(contact.Adress))
            {
                Console.WriteLine("Please add an Adress");
                contact.Adress = Console.ReadLine();
            }

               Console.WriteLine("Add postalcode");
              contact.PostalCode = Console.ReadLine();

            while (string.IsNullOrEmpty(contact.PostalCode))
            {
                Console.WriteLine("Please add an PostalCode");
                contact.PostalCode = Console.ReadLine();
            }

            Console.WriteLine("Add city");
            contact.City = Console.ReadLine() ;
            while (string.IsNullOrEmpty(contact.City))
            {
                Console.WriteLine("Please add an City");
                contact.City = Console.ReadLine();
            }

            ContactList.Add(contact);

            file.SaveToFile(FilePath, JsonConvert.SerializeObject(ContactList));
            Console.Clear();
            MenySystem();
            
        }
    }
}
